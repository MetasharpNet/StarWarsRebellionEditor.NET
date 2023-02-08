namespace SwRebellionConverter
{
    partial class ConvertForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.source = new System.Windows.Forms.PictureBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.PictureBox();
            this.colorTable = new System.Windows.Forms.ComboBox();
            this.colorTableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.extendedColorTable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination)).BeginInit();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.source.Location = new System.Drawing.Point(12, 63);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(256, 256);
            this.source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.source.TabIndex = 0;
            this.source.TabStop = false;
            this.source.DragDrop += new System.Windows.Forms.DragEventHandler(this.source_DragDrop);
            this.source.DragEnter += new System.Windows.Forms.DragEventHandler(this.source_DragEnter);
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(12, 36);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(246, 15);
            this.sourceLabel.TabIndex = 1;
            this.sourceLabel.Text = "Source : drag and drop below your source file";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(298, 36);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(67, 15);
            this.destinationLabel.TabIndex = 3;
            this.destinationLabel.Text = "Destination";
            // 
            // destination
            // 
            this.destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destination.Location = new System.Drawing.Point(289, 63);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(256, 256);
            this.destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.destination.TabIndex = 2;
            this.destination.TabStop = false;
            // 
            // colorTable
            // 
            this.colorTable.FormattingEnabled = true;
            this.colorTable.Location = new System.Drawing.Point(192, 7);
            this.colorTable.Name = "colorTable";
            this.colorTable.Size = new System.Drawing.Size(195, 23);
            this.colorTable.TabIndex = 4;
            // 
            // colorTableLabel
            // 
            this.colorTableLabel.AutoSize = true;
            this.colorTableLabel.Location = new System.Drawing.Point(22, 10);
            this.colorTableLabel.Name = "colorTableLabel";
            this.colorTableLabel.Size = new System.Drawing.Size(164, 15);
            this.colorTableLabel.TabIndex = 5;
            this.colorTableLabel.Text = "Choose the source color table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source: bin (will use color tab or act if provided at the same time), bmp, jpg, j" +
    "peg, png.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination: bin (+act if extended checked) or bmp.";
            // 
            // extendedColorTable
            // 
            this.extendedColorTable.AutoSize = true;
            this.extendedColorTable.Location = new System.Drawing.Point(399, 9);
            this.extendedColorTable.Name = "extendedColorTable";
            this.extendedColorTable.Size = new System.Drawing.Size(134, 19);
            this.extendedColorTable.TabIndex = 8;
            this.extendedColorTable.Text = "extended color table";
            this.extendedColorTable.UseVisualStyleBackColor = true;
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 363);
            this.Controls.Add(this.extendedColorTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorTableLabel);
            this.Controls.Add(this.colorTable);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.source);
            this.Name = "ConvertForm";
            this.Text = "Star Wars Rebellion Converter .NET";
            ((System.ComponentModel.ISupportInitialize)(this.source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox source;
        private Label sourceLabel;
        private Label destinationLabel;
        private PictureBox destination;
        private ComboBox colorTable;
        private Label colorTableLabel;
        private Label label1;
        private Label label2;
        private CheckBox extendedColorTable;
    }
}