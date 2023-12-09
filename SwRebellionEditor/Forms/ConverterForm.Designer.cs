namespace SwRebellionEditor;

partial class ConverterForm
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
        source = new PictureBox();
        sourceLabel = new Label();
        destinationLabel = new Label();
        destination = new PictureBox();
        colorTable = new ComboBox();
        colorTableLabel = new Label();
        label1 = new Label();
        label2 = new Label();
        extendedColorTable = new CheckBox();
        bmpToBmp = new CheckBox();
        ((System.ComponentModel.ISupportInitialize)source).BeginInit();
        ((System.ComponentModel.ISupportInitialize)destination).BeginInit();
        SuspendLayout();
        // 
        // source
        // 
        source.BorderStyle = BorderStyle.FixedSingle;
        source.Location = new Point(12, 63);
        source.Name = "source";
        source.Size = new Size(256, 256);
        source.SizeMode = PictureBoxSizeMode.Zoom;
        source.TabIndex = 0;
        source.TabStop = false;
        source.DragDrop += source_DragDrop;
        source.DragEnter += source_DragEnter;
        // 
        // sourceLabel
        // 
        sourceLabel.AutoSize = true;
        sourceLabel.Location = new Point(12, 36);
        sourceLabel.Name = "sourceLabel";
        sourceLabel.Size = new Size(246, 15);
        sourceLabel.TabIndex = 1;
        sourceLabel.Text = "Source : drag and drop below your source file";
        // 
        // destinationLabel
        // 
        destinationLabel.AutoSize = true;
        destinationLabel.Location = new Point(298, 36);
        destinationLabel.Name = "destinationLabel";
        destinationLabel.Size = new Size(67, 15);
        destinationLabel.TabIndex = 3;
        destinationLabel.Text = "Destination";
        // 
        // destination
        // 
        destination.BorderStyle = BorderStyle.FixedSingle;
        destination.Location = new Point(289, 63);
        destination.Name = "destination";
        destination.Size = new Size(256, 256);
        destination.SizeMode = PictureBoxSizeMode.Zoom;
        destination.TabIndex = 2;
        destination.TabStop = false;
        // 
        // colorTable
        // 
        colorTable.FormattingEnabled = true;
        colorTable.Location = new Point(192, 7);
        colorTable.Name = "colorTable";
        colorTable.Size = new Size(195, 23);
        colorTable.TabIndex = 4;
        // 
        // colorTableLabel
        // 
        colorTableLabel.AutoSize = true;
        colorTableLabel.Location = new Point(22, 10);
        colorTableLabel.Name = "colorTableLabel";
        colorTableLabel.Size = new Size(164, 15);
        colorTableLabel.TabIndex = 5;
        colorTableLabel.Text = "Choose the source color table";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(19, 325);
        label1.Name = "label1";
        label1.Size = new Size(463, 15);
        label1.TabIndex = 6;
        label1.Text = "Source: bin (will use color tab or act if provided at the same time), bmp, jpg, jpeg, png.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(57, 344);
        label2.Name = "label2";
        label2.Size = new Size(279, 15);
        label2.TabIndex = 7;
        label2.Text = "Destination: bin (+act if extended checked) or bmp.";
        // 
        // extendedColorTable
        // 
        extendedColorTable.AutoSize = true;
        extendedColorTable.Location = new Point(399, 9);
        extendedColorTable.Name = "extendedColorTable";
        extendedColorTable.Size = new Size(134, 19);
        extendedColorTable.TabIndex = 8;
        extendedColorTable.Text = "extended color table";
        extendedColorTable.UseVisualStyleBackColor = true;
        // 
        // bmpToBmp
        // 
        bmpToBmp.AutoSize = true;
        bmpToBmp.Location = new Point(399, 32);
        bmpToBmp.Name = "bmpToBmp";
        bmpToBmp.Size = new Size(118, 19);
        bmpToBmp.TabIndex = 9;
        bmpToBmp.Text = "bmp to bin+bmp";
        bmpToBmp.UseVisualStyleBackColor = true;
        // 
        // ConverterForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(557, 363);
        Controls.Add(bmpToBmp);
        Controls.Add(extendedColorTable);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(colorTableLabel);
        Controls.Add(colorTable);
        Controls.Add(destinationLabel);
        Controls.Add(destination);
        Controls.Add(sourceLabel);
        Controls.Add(source);
        Name = "ConverterForm";
        Text = "Pictures Converter";
        ((System.ComponentModel.ISupportInitialize)source).EndInit();
        ((System.ComponentModel.ISupportInitialize)destination).EndInit();
        ResumeLayout(false);
        PerformLayout();
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
    private CheckBox bmpToBmp;
}