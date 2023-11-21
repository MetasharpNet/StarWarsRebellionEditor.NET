using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class CoreSystemsFacilitiesTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private int currIndex;
        private static string shipSelected = "";
        private static int unitType = 0;
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            openNew = new Button();
            SaveAs = new Button();
            Cancel = new Button();
            Ok = new Button();
            facilityComboBox = new ComboBox();
            delGroupButton = new Button();
            addGroupButton = new Button();
            facilitiesDataGridView = new DataGridView();
            entryColumn = new DataGridViewTextBoxColumn();
            randomTresholdColumn = new DataGridViewTextBoxColumn();
            groupColumn = new DataGridViewTextBoxColumn();
            infoLabel = new Label();
            formulaLabel = new Label();
            ((ISupportInitialize)facilitiesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // openNew
            // 
            openNew.Location = new Point(496, 453);
            openNew.Margin = new Padding(4, 3, 4, 3);
            openNew.Name = "openNew";
            openNew.Size = new Size(88, 27);
            openNew.TabIndex = 53;
            openNew.Text = "Open...";
            openNew.UseVisualStyleBackColor = true;
            openNew.Click += Open_Click;
            // 
            // SaveAs
            // 
            SaveAs.Location = new Point(402, 453);
            SaveAs.Margin = new Padding(4, 3, 4, 3);
            SaveAs.Name = "SaveAs";
            SaveAs.Size = new Size(88, 27);
            SaveAs.TabIndex = 52;
            SaveAs.Text = "&SaveAs...";
            SaveAs.UseVisualStyleBackColor = true;
            SaveAs.Click += SaveAs_Click;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(128, 453);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 51;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(34, 453);
            Ok.Margin = new Padding(4, 3, 4, 3);
            Ok.Name = "Ok";
            Ok.Size = new Size(88, 27);
            Ok.TabIndex = 50;
            Ok.Text = "&Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // facilityComboBox
            // 
            facilityComboBox.FormattingEnabled = true;
            facilityComboBox.Location = new Point(6, 421);
            facilityComboBox.Name = "facilityComboBox";
            facilityComboBox.Size = new Size(232, 23);
            facilityComboBox.TabIndex = 61;
            // 
            // delGroupButton
            // 
            delGroupButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delGroupButton.ForeColor = Color.Red;
            delGroupButton.Location = new Point(288, 421);
            delGroupButton.Name = "delGroupButton";
            delGroupButton.Size = new Size(38, 23);
            delGroupButton.TabIndex = 60;
            delGroupButton.Text = "Del";
            delGroupButton.UseVisualStyleBackColor = true;
            delGroupButton.Click += delGroupButton_Click;
            // 
            // addGroupButton
            // 
            addGroupButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addGroupButton.Location = new Point(244, 421);
            addGroupButton.Name = "addGroupButton";
            addGroupButton.Size = new Size(38, 24);
            addGroupButton.TabIndex = 59;
            addGroupButton.Text = "Add";
            addGroupButton.UseVisualStyleBackColor = true;
            addGroupButton.Click += addGroupButton_Click;
            // 
            // facilitiesDataGridView
            // 
            facilitiesDataGridView.AllowUserToAddRows = false;
            facilitiesDataGridView.AllowUserToDeleteRows = false;
            facilitiesDataGridView.AllowUserToResizeColumns = false;
            facilitiesDataGridView.AllowUserToResizeRows = false;
            facilitiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            facilitiesDataGridView.Columns.AddRange(new DataGridViewColumn[] { entryColumn, randomTresholdColumn, groupColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            facilitiesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            facilitiesDataGridView.Location = new Point(6, 44);
            facilitiesDataGridView.Name = "facilitiesDataGridView";
            facilitiesDataGridView.RowHeadersVisible = false;
            facilitiesDataGridView.RowTemplate.Height = 25;
            facilitiesDataGridView.Size = new Size(322, 371);
            facilitiesDataGridView.TabIndex = 62;
            facilitiesDataGridView.CellValueChanged += facilitiesDataGridView_CellValueChanged;
            // 
            // entryColumn
            // 
            entryColumn.HeaderText = "Id";
            entryColumn.Name = "entryColumn";
            entryColumn.ReadOnly = true;
            entryColumn.Resizable = DataGridViewTriState.False;
            entryColumn.Width = 32;
            // 
            // randomTresholdColumn
            // 
            randomTresholdColumn.HeaderText = "Random Treshold";
            randomTresholdColumn.Name = "randomTresholdColumn";
            randomTresholdColumn.Resizable = DataGridViewTriState.False;
            randomTresholdColumn.Width = 55;
            // 
            // groupColumn
            // 
            groupColumn.HeaderText = "Army";
            groupColumn.Name = "groupColumn";
            groupColumn.ReadOnly = true;
            groupColumn.Resizable = DataGridViewTriState.False;
            groupColumn.Width = 232;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(13, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(263, 15);
            infoLabel.TabIndex = 63;
            infoLabel.Text = "Define here initial random Core Systems facilities.";
            // 
            // formulaLabel
            // 
            formulaLabel.AutoSize = true;
            formulaLabel.Location = new Point(13, 26);
            formulaLabel.Name = "formulaLabel";
            formulaLabel.Size = new Size(500, 15);
            formulaLabel.TabIndex = 65;
            formulaLabel.Text = "Game rolls 0-100 numbers N. Each creates a facility with highest random treshold < N (if any).";
            // 
            // RimSystemsFacilitiesTablesForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = Cancel;
            ClientSize = new Size(609, 486);
            Controls.Add(formulaLabel);
            Controls.Add(infoLabel);
            Controls.Add(facilitiesDataGridView);
            Controls.Add(facilityComboBox);
            Controls.Add(delGroupButton);
            Controls.Add(addGroupButton);
            Controls.Add(openNew);
            Controls.Add(SaveAs);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(625, 525);
            MinimumSize = new Size(625, 525);
            Name = "CoreSystemsFacilitiesTablesForm";
            Text = "Core Systems Facilities Table (SYFCCRTB.DAT)";
            Load += GameObjectsListForm_Load;
            ((ISupportInitialize)facilitiesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox facilityComboBox;
        private Button delGroupButton;
        private Button addGroupButton;
        private DataGridView facilitiesDataGridView;
        private Label infoLabel;
        private DataGridViewTextBoxColumn entryColumn;
        private DataGridViewTextBoxColumn randomTresholdColumn;
        private DataGridViewTextBoxColumn groupColumn;
        private Label formulaLabel;
    }
}