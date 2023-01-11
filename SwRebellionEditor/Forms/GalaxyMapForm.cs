using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;

namespace SwRebellionEditor
{
    public partial class GalaxyMapForm : GalaxyMapDesignForm
    {
        #region .ctor

        public GalaxyMapForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SECTORSD.DAT";
            GameFile = DatFile.Load<SECTORSD>(GameFilePath);
            InitializeComponent();
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
                label.BringToFront();
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
            //TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
            //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
        }

        #endregion

        #region Changed events

        private void xPosition_ValueChanged(object sender, EventArgs e)
        {
            //GameFile.Sectors[selector.Value].XPosition = (ushort)xPosition.Value;
            GameFile.UnsavedData = true;
        }
        private void yPosition_ValueChanged(object sender, EventArgs e)
        {
            //GameFile.Sectors[selector.Value].YPosition = (ushort)yPosition.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
