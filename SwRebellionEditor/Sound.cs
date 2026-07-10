using System.Media;

namespace SwRebellionEditor;

public static class Sound
{
    private static Random _random = new Random(DateTime.Now.Millisecond);

    public static void Play(Stream audioStream)
    {
        // foreground thread: keeps the process alive until the clip ends when closing the app,
        // and PlaySync keeps the player alive for the whole playback, all without blocking the UI
        var thread = new Thread(() =>
        {
            using (var soundPlayer = new SoundPlayer(audioStream))
            {
                soundPlayer.PlaySync();
            }
        });
        thread.IsBackground = false;
        thread.Start();
    }

    private static SoundPlayer _musicSoundPlayer;
    static Sound()
    {
        _musicSoundPlayer = new SoundPlayer();
    }
    public static void PlayMusic(string filePath, bool looping = true)
    {
        _musicSoundPlayer!.Stop();
        _musicSoundPlayer.SoundLocation = filePath;
        if (looping)
            _musicSoundPlayer.PlayLooping();
        else
            _musicSoundPlayer.Play();
    }
    public static void StopMusic()
    {
        _musicSoundPlayer!.Stop();
    }

    public static void PlayRandomMusic()
    {
        if (!Settings.Current.IsRebellionCdLoaded)
            return;
        PlayMusic(Path.Combine(Settings.Current.GameFolder, "MDATA\\MDATA." + _random.Next(300, 315)));
    }
}
