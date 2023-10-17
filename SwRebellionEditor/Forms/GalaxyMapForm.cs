namespace SwRebellionEditor;

public partial class GalaxyMapForm : GalaxyMapDesignForm
{
    #region .ctor

    public Dictionary<MovableLabel, SECTORSD_Sector> SectorsDic;
    public Dictionary<MovableLabel, SYSTEMSD_System> SystemsDic;
    public List<MovableLabel> SystemsSprites;
    public SYSTEMSD SystemsGameFile;
    public string SystemsGameFilePath;
    public MovableLabel CurrentSectorSprite;

    public GalaxyMapForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
        GameFile = DatFile.Load<SECTORSD>(GameFilePath);
        SystemsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
        SystemsGameFile = DatFile.Load<SYSTEMSD>(SystemsGameFilePath);
        InitializeComponent();
        SectorsDic = new Dictionary<MovableLabel, SECTORSD_Sector>();
        SystemsDic = new Dictionary<MovableLabel, SYSTEMSD_System>();
        SystemsSprites = new List<MovableLabel>();
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        foreach (var sector in GameFile.Sectors)
        {
            var sectorSprite = new MovableLabel(galaxyMap, 97, 57, sectorX, sectorY)
                {
                    Width = 79,
                    Height = 102,
                    Location = new Point(galaxyMap.Location.X + sector.XPosition - 97, galaxyMap.Location.Y + sector.YPosition - 57),
                    Text = sector.Name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue
                };
            sectorSprite.MouseDown += sector_MouseDown;
            sectorSprite.MouseMove += sector_PositionChanged;
            Controls.Add(sectorSprite);
            sectorSprite.BringToFront();
            SectorsDic.Add(sectorSprite, sector);
        }
    }
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.Sectors)
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
        foreach (var s in SystemsGameFile.Systems)
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
    }
    protected override void SaveSideInfo()
    {
        GameFile.Save(GameFilePath);
        SystemsGameFile.Save(SystemsGameFilePath);
    }

    #endregion

    #region Changed events

    private void sector_MouseDown(object sender, MouseEventArgs e)
    {
        CurrentSectorSprite = (MovableLabel)sender;
        var sector = SectorsDic[CurrentSectorSprite];
        sectorName.Text = sector.Name;
        systemName.Text = "-";
        systemX.Text = "-";
        systemY.Text = "-";
        var sectorSystems = SystemsGameFile.Systems.Where(s => s.SectorId == sector.Id).ToList();

        foreach (var systemSprite in SystemsSprites)
        {
            Controls.Remove(systemSprite);
            systemSprite.Dispose();
        }
        SystemsSprites.Clear();
        SystemsDic.Clear();

        var colors = new List<Color> { Color.LightBlue, Color.LightCoral, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGray,
                                       Color.LightGreen, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightYellow };
        int c = 0;
        foreach (var system in sectorSystems)
        {
            var systemSprite = new MovableLabel(sectorMap)
                {
                    Width = 19,
                    Height = 18,
                    Location = new Point(sectorMap.Location.X + system.XPosition - sector.XPosition - 4, sectorMap.Location.Y + system.YPosition - sector.YPosition - 1),
                    Text = system.Name[0].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                    BackColor = colors[c++]
                };
            systemSprite.MouseMove += system_PositionChanged;
            systemSprite.MouseDown += system_MouseDown;
            Controls.Add(systemSprite);
            systemSprite.BringToFront();
            SystemsSprites.Add(systemSprite);
            SystemsDic.Add(systemSprite, system);
        }
    }

    private void sector_PositionChanged(object sender, MouseEventArgs e)
    {
        var sectorSprite = (MovableLabel)sender;
        if (sectorSprite.IsMoving)
        {
            var sector = SectorsDic[sectorSprite];
            var xDiff = sector.XPosition - sectorSprite.X;
            var yDiff = sector.YPosition - sectorSprite.Y;
            sector.XPosition = sectorSprite.X;
            sector.YPosition = sectorSprite.Y;
            var sectorSystems = SystemsGameFile.Systems.Where(s => s.SectorId == sector.Id).ToList();
            foreach (var system in sectorSystems)
            {
                system.XPosition -= (ushort)xDiff;
                system.YPosition -= (ushort)yDiff;
            }
            GameFile.UnsavedData = true;
        }
    }
    private void system_MouseDown(object sender, MouseEventArgs e)
    {
        var systemSprite = (MovableLabel)sender;
        var system = SystemsDic[systemSprite];
        systemName.Text = system.Name;
        systemX.Text = system.XPosition.ToString();
        systemY.Text = system.YPosition.ToString();
    }
    private void system_PositionChanged(object sender, MouseEventArgs e)
    {
        var systemSprite = (MovableLabel)sender;
        if (systemSprite.IsMoving)
        {
            var system = SystemsDic[systemSprite];
            var sector = GameFile.Sectors.First(s => s.Id == system.SectorId);
            system.XPosition = (ushort)(systemSprite.Location.X - sectorMap.Location.X + CurrentSectorSprite.X + 4);
            system.YPosition = (ushort)(systemSprite.Location.Y - sectorMap.Location.Y + CurrentSectorSprite.Y + 1);
            systemX.Text = system.XPosition.ToString();
            systemY.Text = system.YPosition.ToString();
            GameFile.UnsavedData = true;
        }
    }
    #endregion
}
