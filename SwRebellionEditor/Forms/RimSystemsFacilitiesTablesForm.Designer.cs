using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class RimSystemsFacilitiesTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Button Cancel;
        private Button Save;

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
            Cancel = new Button();
            Save = new Button();
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
            //             // SaveAs
            // 
            
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
            // Save
            // 
            Save.Location = new Point(34, 453);
            Save.Margin = new Padding(4, 3, 4, 3);
            Save.Name = "Save";
            Save.Size = new Size(88, 27);
            Save.TabIndex = 50;
            Save.Text = "&Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
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
            infoLabel.Text = "Define here initial random Rim Systems facilities.";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AcceptButton = Save;
                        CancelButton = Cancel;
            ClientSize = new Size(609, 486);
            Controls.Add(formulaLabel);
            Controls.Add(infoLabel);
            Controls.Add(facilitiesDataGridView);
            Controls.Add(facilityComboBox);
            Controls.Add(delGroupButton);
            Controls.Add(addGroupButton);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Margin = new Padding(4, 3, 4, 3);
            Text = "Rim Systems Facilities Table (SYFCRMTB.DAT)";
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






