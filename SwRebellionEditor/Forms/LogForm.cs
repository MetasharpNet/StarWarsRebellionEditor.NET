namespace SwRebellionEditor.Forms
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        public void AppendMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendMessage), message);
            }
            else
            {
                LogTextBox.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH'h'mm'm'ss's'] ") + message + Environment.NewLine);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
