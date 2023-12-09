using SwRebellionEditor;
using SwRebellionEditor.ResourceHelpers;
using System.Security.Policy;

namespace SwRebellionEditor;

public partial class ConverterForm : Form
{
    public ConverterForm()
    {
        InitializeComponent();
        source.AllowDrop = true;
        colorTable.Items.Add("strategy-dll.act");
        colorTable.Items.Add("tactical-dll.act");
        colorTable.SelectedIndex = 1;
    }

    private void source_DragDrop(object sender, DragEventArgs e)
    {
        var filesPaths = ((string[])e.Data.GetData(DataFormats.FileDrop)).ToList();
        var actFiles = filesPaths.Where(f => f.ToLowerInvariant().EndsWith(".act")).ToList();
        foreach (var file in filesPaths.Where(f => !f.ToLowerInvariant().EndsWith(".act")))
        {
            if (File.Exists(file))
            {
                var fileLow = file.ToLowerInvariant();
                var filename = Path.GetFileNameWithoutExtension(file);
                var actFile = actFiles.FirstOrDefault(f => Path.GetFileName(f) == filename + ".act");
                BinImage bi;
                if ((fileLow.EndsWith(".bmp") || fileLow.EndsWith(".jpg") || fileLow.EndsWith(".jpeg") || fileLow.EndsWith(".png")))
                {
                    var b = new Bitmap(file);
                    source.Image = Tools.ToMemoryBitmap(b);
                    if (actFile != null)
                        bi = new BinImage(b, new AdobeColorTable(actFile), !extendedColorTable.Checked);
                    else
                        bi = new BinImage(b, new AdobeColorTable(colorTable.Text), !extendedColorTable.Checked);
                    destination.Image = Tools.ToMemoryBitmap(bi.ToBitmap());
                    bi.Save(Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".bin"));
                    if (extendedColorTable.Checked)
                        bi.ColorTable.Save(Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".act"));
                    b.Dispose();

                    if (bmpToBmp.Checked)
                    {
                        b = bi.ToBitmap();
                        source.Image = Tools.ToMemoryBitmap(b);
                        destination.Image = Tools.ToMemoryBitmap(bi.ToBitmap());
                        b.Save(Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + "+.bmp"));
                        b.Dispose();
                    }
                }
                else if (fileLow.EndsWith(".bin"))
                {
                    bi = new BinImage(file);
                    if (actFile != null)
                        bi.ColorTable = new AdobeColorTable(actFile);
                    else
                        bi.ColorTable = new AdobeColorTable(colorTable.Text);
                    var b = bi.ToBitmap();
                    source.Image = Tools.ToMemoryBitmap(b);
                    destination.Image = Tools.ToMemoryBitmap(bi.ToBitmap());
                    b.Save(Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".bmp"));
                    b.Dispose();
                }
            }
        }
    }

    private void source_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }
}