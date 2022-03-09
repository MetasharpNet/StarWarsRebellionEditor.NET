using System.Reflection;

namespace SwRebellionEditor
{
    public partial class AboutForm : Form
    {
        #region Business Layer

        public TAttribute? Get<TAttribute>()
             where TAttribute : Attribute
        {
            var customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(TAttribute), false);
            return customAttributes.Length == 0 ? null : (TAttribute)customAttributes[0];
        }

        #endregion

        #region .ctor

        public AboutForm()
        {
            InitializeComponent();
            Text = "About "+ Get<AssemblyTitleAttribute>()?.Title + ".exe";
            Product_Label.Text = Get<AssemblyProductAttribute>()?.Product;
            Version_Label.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version?.ToString();
            Copyright_Label.Text = Get<AssemblyCopyrightAttribute>()?.Copyright;
            Company_Label.Text = Get<AssemblyCompanyAttribute>()?.Company;
            Description_TextBox.Text = Get<AssemblyDescriptionAttribute>()?.Description;
        }

        #endregion

        #region Form events

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RegistryKeys.PlaySounds)
                Sound.Play(Resources.well_if_you_will_not_be_needing_me_wav);
            if (!RegistryKeys.PlayMusic)
                return;
            Sound.PlayRandomMusic();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            if (!RegistryKeys.IsFirstStart && RegistryKeys.PlaySounds)
                Sound.Play(Resources.how_can_i_assist_you_wav);
            if (!RegistryKeys.PlayMusic)
                return;
            Sound.PlayRandomMusic();
        }

        #endregion

        #region Controls events

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
