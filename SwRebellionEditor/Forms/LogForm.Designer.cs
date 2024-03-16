namespace SwRebellionEditor.Forms
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogTextBox = new TextBox();
            CancelButton = new Button();
            OkButton = new Button();
            SuspendLayout();
            // 
            // LogTextBox
            // 
            LogTextBox.Location = new Point(0, 0);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ScrollBars = ScrollBars.Both;
            LogTextBox.Size = new Size(800, 414);
            LogTextBox.TabIndex = 0;
            LogTextBox.WordWrap = false;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 420);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(131, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += cancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Enabled = false;
            OkButton.Location = new Point(657, 420);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(131, 23);
            OkButton.TabIndex = 2;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            Controls.Add(LogTextBox);
            Name = "LogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogTextBox;
        public Button CancelButton;
        public Button OkButton;
    }
}