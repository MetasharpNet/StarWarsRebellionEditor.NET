namespace SwRebellionEditor;

public partial class GalaxyMapForm : GalaxyMapDesignForm
{
    #region .ctor

    protected HashSet<MovableLabel> movedSectorsLabels;
    protected Dictionary<MovableLabel, SECTORSD_Sector> sectorsDic;

    public GalaxyMapForm()
    {
        GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SECTORSD.DAT";
        GameFile = DatFile.Load<SECTORSD>(GameFilePath);
        InitializeComponent();
        movedSectorsLabels = new HashSet<MovableLabel>();
        sectorsDic = new Dictionary<MovableLabel, SECTORSD_Sector>();
    }

    #endregion

    #region Business Layer


    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        foreach (var sector in GameFile.Sectors)
        {
            var label = new MovableLabel(background, 97, 57, x, y);
            Controls.Add(label);
            label.Width = 79;
            label.Height = 102;
            label.Location = new Point(background.Location.X + sector.XPosition - 97, background.Location.Y + sector.YPosition - 57);
            label.Text = sector.Name;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BringToFront();
            label.MouseMove += sectorsPositions_ValueChanged;
            sectorsDic.Add(label, sector);
        }
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.Sectors)
            s.Name = TextStra.GetString(s.TextStraDllId);
    }
    protected override void SaveSideInfo()
    {
        var systemsGamefile = DatFile.Load<SYSTEMSD>(RegistryKeys.InstalledLocation + "\\GData\\SYSTEMSD.DAT");
        foreach (var sectorLabel in movedSectorsLabels)
        {
            var sector = sectorsDic[sectorLabel];
            var xDiff = sector.XPosition - sectorLabel.X;
            var yDiff = sector.YPosition - sectorLabel.Y;
            foreach (var sys in systemsGamefile.Systems.Where(s => s.SectorId == sector.Id))
            {
                sys.XPosition -= (ushort)xDiff;
                sys.YPosition -= (ushort)yDiff;
            }
        }
        systemsGamefile.Save(RegistryKeys.InstalledLocation + "\\GData\\SYSTEMSD.DAT");
    }

    #endregion

    #region Changed events

    private void sectorsPositions_ValueChanged(object sender, MouseEventArgs e)
    {
        var label = (MovableLabel)sender;
        if (label.IsMoving)
        {
            if (!movedSectorsLabels.Contains(label))
                movedSectorsLabels.Add(label);
            var sec = GameFile.Sectors.First(s => s == sectorsDic[label]);
            sec.XPosition = (ushort)label.X;
            sec.YPosition = (ushort)label.Y;
            GameFile.UnsavedData = true;
        }
    }

    #endregion
}
