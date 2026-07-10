using System.Diagnostics;
using System.IO.Compression;
using System.Text.Json;
using System.Text.RegularExpressions;
using SwRebellionEditor.Forms;

namespace SwRebellionEditor;

// Both lookups below are anonymous: no GitHub account or token is ever needed.
public static class AutoUpdate
{
    private const string Repo = "MetasharpNet/StarWarsRebellionEditor.NET";
    // /releases/latest only returns the release marked "Latest" on GitHub:
    // drafts, pre-releases and side-file releases (never marked "Latest") are excluded
    private const string LatestReleaseApiUrl = "https://api.github.com/repos/" + Repo + "/releases/latest";
    private const string LatestReleasePageUrl = "https://github.com/" + Repo + "/releases/latest";

    public static async Task CheckAndProposeAsync(Form owner)
    {
        (string Tag, Version Version, string ZipUrl)? found = null;
        try
        {
            // primary: anonymous GitHub API (public endpoint, only a User-Agent header is required)
            found = await GetLatestViaApiAsync();
        }
        catch
        {
            // rate-limited or unreachable: fall back below
        }
        if (found == null)
        {
            try
            {
                // fallback without any API: the "latest" page redirects to the tag,
                // and editor release assets are always named "{tag}.zip"
                found = await GetLatestViaRedirectAsync();
            }
            catch
            {
                return; // offline: the editor works without the update check
            }
        }
        if (found == null)
            return; // latest release holds no editor zip
        var (tag, latest, zipUrl) = found.Value;
        var current = typeof(AutoUpdate).Assembly.GetName().Version!;
        if (latest <= current)
            return;
        if (tag == Settings.Current.SkippedUpdateTag)
            return;
        var answer = MessageBox.Show(owner,
            "A new version of the editor is available on GitHub." + Environment.NewLine + Environment.NewLine +
            "Current version: " + current + Environment.NewLine +
            "Latest release: " + latest + Environment.NewLine + Environment.NewLine +
            "Download and install it now? (the editor will restart)",
            "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (answer != DialogResult.Yes)
        {
            // don't ask again for this release; the next one will prompt again
            Settings.Current.SkippedUpdateTag = tag;
            Settings.Current.Serialize();
            return;
        }
        await DownloadAndInstallAsync(owner, zipUrl);
    }

    private static async Task<(string, Version, string)?> GetLatestViaApiAsync()
    {
        using var http = NewHttpClient();
        var json = await http.GetStringAsync(LatestReleaseApiUrl);
        using var release = JsonDocument.Parse(json);
        var tag = release.RootElement.GetProperty("tag_name").GetString() ?? "";
        foreach (var asset in release.RootElement.GetProperty("assets").EnumerateArray())
        {
            var name = asset.GetProperty("name").GetString() ?? "";
            var match = Regex.Match(name, @"^swr-editor\.net-(\d+\.\d+\.\d+\.\d+).*\.zip$");
            if (match.Success)
                return (tag, new Version(match.Groups[1].Value), asset.GetProperty("browser_download_url").GetString()!);
        }
        return null;
    }

    private static async Task<(string, Version, string)?> GetLatestViaRedirectAsync()
    {
        using var handler = new HttpClientHandler { AllowAutoRedirect = false };
        using var http = NewHttpClient(handler);
        using var response = await http.GetAsync(LatestReleasePageUrl);
        var location = response.Headers.Location?.ToString() ?? "";
        var match = Regex.Match(location, @"/releases/tag/(swr-editor\.net-(\d+\.\d+\.\d+\.\d+)[^/]*)$");
        if (!match.Success)
            return null; // not an editor release
        var tag = Uri.UnescapeDataString(match.Groups[1].Value);
        var zipUrl = "https://github.com/" + Repo + "/releases/download/" + tag + "/" + tag + ".zip";
        return (tag, new Version(match.Groups[2].Value), zipUrl);
    }

    private static async Task DownloadAndInstallAsync(Form owner, string zipUrl)
    {
        var logForm = new LogForm();
        logForm.Text = "Editor update";
        logForm.Show(owner);
        try
        {
            var tempZip = Path.Combine(Path.GetTempPath(), "swr-editor-update.zip");
            var tempDir = Path.Combine(Path.GetTempPath(), "swr-editor-update");
            logForm.AppendMessage("Downloading " + zipUrl);
            using (var http = NewHttpClient())
            using (var response = await http.GetAsync(zipUrl, HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                var totalBytes = response.Content.Headers.ContentLength ?? -1;
                using var source = await response.Content.ReadAsStreamAsync();
                using var target = File.Create(tempZip);
                var buffer = new byte[1024 * 1024];
                long downloadedBytes = 0;
                int lastReportedPercent = -1;
                int read;
                while ((read = await source.ReadAsync(buffer)) > 0)
                {
                    await target.WriteAsync(buffer.AsMemory(0, read));
                    downloadedBytes += read;
                    if (totalBytes > 0)
                    {
                        var percent = (int)(downloadedBytes * 100 / totalBytes);
                        if (percent >= lastReportedPercent + 5)
                        {
                            logForm.AppendMessage("Downloaded " + percent + "% (" + (downloadedBytes / 1024 / 1024) + " MB)");
                            lastReportedPercent = percent;
                        }
                    }
                }
            }
            logForm.AppendMessage("Extracting...");
            if (Directory.Exists(tempDir))
                Directory.Delete(tempDir, true);
            await Task.Run(() => ZipFile.ExtractToDirectory(tempZip, tempDir));
            File.Delete(tempZip);
            // if the zip wraps everything in a single root folder, install from that folder
            var sourceDir = tempDir;
            var entries = Directory.GetFileSystemEntries(tempDir);
            if (entries.Length == 1 && Directory.Exists(entries[0]))
                sourceDir = entries[0];
            var appDir = AppContext.BaseDirectory.TrimEnd('\\');
            var updaterPath = Path.Combine(Path.GetTempPath(), "swr-editor-update.cmd");
            File.WriteAllText(updaterPath,
                "@echo off\r\n" +
                "timeout /t 2 /nobreak >nul\r\n" +
                "robocopy \"" + sourceDir + "\" \"" + appDir + "\" /E /IS /IT /R:10 /W:1 >nul\r\n" +
                "rmdir /s /q \"" + tempDir + "\"\r\n" +
                "start \"\" /D \"" + appDir + "\" \"" + Path.Combine(appDir, "SwRebellionEditor.exe") + "\"\r\n" +
                "del \"%~f0\"\r\n");
            logForm.AppendMessage("Closing the editor to finish the update...");
            Process.Start(new ProcessStartInfo
            {
                FileName = updaterPath,
                CreateNoWindow = true,
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
            Application.Exit();
        }
        catch (Exception ex)
        {
            logForm.AppendMessage("[ERROR] Update failed: " + ex.Message);
            logForm.AppendMessage("You can download it manually from " + LatestReleasePageUrl);
            logForm.OkButton.Enabled = true;
        }
    }

    private static HttpClient NewHttpClient(HttpClientHandler? handler = null)
    {
        var http = handler == null ? new HttpClient() : new HttpClient(handler);
        http.DefaultRequestHeaders.UserAgent.ParseAdd("SwRebellionEditor"); // required by github.com, no auth involved
        http.Timeout = TimeSpan.FromMinutes(30); // large asset download on slow connections
        return http;
    }
}
