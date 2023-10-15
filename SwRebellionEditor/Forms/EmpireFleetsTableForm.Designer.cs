using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class EmpireFleetsTableForm
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
            unitsListView = new ListView();
            columnHeader4 = new ColumnHeader();
            addUnitButton = new Button();
            delUnitButton = new Button();
            unitComboBox = new ComboBox();
            armyComboBox = new ComboBox();
            delArmyButton = new Button();
            addArmyButton = new Button();
            armiesDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            percentColumn = new DataGridViewTextBoxColumn();
            armyColumn = new DataGridViewTextBoxColumn();
            infoLabel = new Label();
            ((ISupportInitialize)armiesDataGridView).BeginInit();
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
            // unitsListView
            // 
            unitsListView.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            unitsListView.FullRowSelect = true;
            unitsListView.GridLines = true;
            unitsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            unitsListView.Location = new Point(332, 31);
            unitsListView.Margin = new Padding(4, 3, 4, 3);
            unitsListView.MultiSelect = false;
            unitsListView.Name = "unitsListView";
            unitsListView.Size = new Size(271, 384);
            unitsListView.TabIndex = 55;
            unitsListView.UseCompatibleStateImageBehavior = false;
            unitsListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Army Units (First is container)";
            columnHeader4.Width = 265;
            // 
            // addUnitButton
            // 
            addUnitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addUnitButton.Location = new Point(521, 421);
            addUnitButton.Name = "addUnitButton";
            addUnitButton.Size = new Size(38, 24);
            addUnitButton.TabIndex = 56;
            addUnitButton.Text = "Add";
            addUnitButton.UseVisualStyleBackColor = true;
            addUnitButton.Click += addUnitButton_Click;
            // 
            // delUnitButton
            // 
            delUnitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delUnitButton.ForeColor = Color.Red;
            delUnitButton.Location = new Point(565, 421);
            delUnitButton.Name = "delUnitButton";
            delUnitButton.Size = new Size(38, 24);
            delUnitButton.TabIndex = 57;
            delUnitButton.Text = "Del";
            delUnitButton.UseVisualStyleBackColor = true;
            delUnitButton.Click += delUnitButton_Click;
            // 
            // unitComboBox
            // 
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(332, 421);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(183, 23);
            unitComboBox.TabIndex = 58;
            // 
            // armyComboBox
            // 
            armyComboBox.FormattingEnabled = true;
            armyComboBox.Location = new Point(6, 421);
            armyComboBox.Name = "armyComboBox";
            armyComboBox.Size = new Size(232, 23);
            armyComboBox.TabIndex = 61;
            // 
            // delArmyButton
            // 
            delArmyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delArmyButton.ForeColor = Color.Red;
            delArmyButton.Location = new Point(288, 421);
            delArmyButton.Name = "delArmyButton";
            delArmyButton.Size = new Size(38, 23);
            delArmyButton.TabIndex = 60;
            delArmyButton.Text = "Del";
            delArmyButton.UseVisualStyleBackColor = true;
            delArmyButton.Click += delArmyButton_Click;
            // 
            // addArmyButton
            // 
            addArmyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addArmyButton.Location = new Point(244, 421);
            addArmyButton.Name = "addArmyButton";
            addArmyButton.Size = new Size(38, 24);
            addArmyButton.TabIndex = 59;
            addArmyButton.Text = "Add";
            addArmyButton.UseVisualStyleBackColor = true;
            addArmyButton.Click += addArmyButton_Click;
            // 
            // armiesDataGridView
            // 
            armiesDataGridView.AllowUserToAddRows = false;
            armiesDataGridView.AllowUserToDeleteRows = false;
            armiesDataGridView.AllowUserToResizeColumns = false;
            armiesDataGridView.AllowUserToResizeRows = false;
            armiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            armiesDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, percentColumn, armyColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            armiesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            armiesDataGridView.Location = new Point(6, 31);
            armiesDataGridView.Name = "armiesDataGridView";
            armiesDataGridView.RowHeadersVisible = false;
            armiesDataGridView.RowTemplate.Height = 25;
            armiesDataGridView.Size = new Size(322, 384);
            armiesDataGridView.TabIndex = 62;
            armiesDataGridView.CellValueChanged += armiesDataGridView_CellValueChanged;
            armiesDataGridView.SelectionChanged += armiesDataGridView_SelectionChanged;
            // 
            // idColumn
            // 
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Resizable = DataGridViewTriState.False;
            idColumn.Width = 32;
            // 
            // percentColumn
            // 
            percentColumn.HeaderText = "%";
            percentColumn.Name = "percentColumn";
            percentColumn.Resizable = DataGridViewTriState.False;
            percentColumn.Width = 32;
            // 
            // armyColumn
            // 
            armyColumn.HeaderText = "Army";
            armyColumn.Name = "armyColumn";
            armyColumn.ReadOnly = true;
            armyColumn.Resizable = DataGridViewTriState.False;
            armyColumn.Width = 255;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(13, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(534, 15);
            infoLabel.TabIndex = 63;
            infoLabel.Text = "You can define here the Empire fleets randomly spread in the galaxy at start with their probabilities.";
            // 
            // EmpireUnitsTableForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(609, 486);
            Controls.Add(infoLabel);
            Controls.Add(armiesDataGridView);
            Controls.Add(armyComboBox);
            Controls.Add(delArmyButton);
            Controls.Add(addArmyButton);
            Controls.Add(unitComboBox);
            Controls.Add(delUnitButton);
            Controls.Add(addUnitButton);
            Controls.Add(unitsListView);
            Controls.Add(openNew);
            Controls.Add(SaveAs);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(625, 525);
            MinimumSize = new Size(625, 525);
            Name = "EmpireFleetsTableForm";
            Text = "Empire Fleets Table (CMUNEFTB.DAT)";
            Load += GameObjectsListForm_Load;
            ((ISupportInitialize)armiesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView unitsListView;
        private ColumnHeader columnHeader4;
        private Button addUnitButton;
        private Button delUnitButton;
        private ComboBox unitComboBox;
        private ComboBox armyComboBox;
        private Button delArmyButton;
        private Button addArmyButton;
        private DataGridView armiesDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn percentColumn;
        private DataGridViewTextBoxColumn armyColumn;
        private Label infoLabel;
    }
}