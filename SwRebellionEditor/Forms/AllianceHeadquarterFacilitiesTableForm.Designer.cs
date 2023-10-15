using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class AllianceHeadquarterFacilitiesTableForm
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
            itemsListView = new ListView();
            itemsColumn = new ColumnHeader();
            addItemButton = new Button();
            delItemButton = new Button();
            itemComboBox = new ComboBox();
            groupComboBox = new ComboBox();
            delGroupButton = new Button();
            addGroupButton = new Button();
            groupsDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            groupColumn = new DataGridViewTextBoxColumn();
            infoLabel = new Label();
            ((ISupportInitialize)groupsDataGridView).BeginInit();
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
            // itemsListView
            // 
            itemsListView.Columns.AddRange(new ColumnHeader[] { itemsColumn });
            itemsListView.FullRowSelect = true;
            itemsListView.GridLines = true;
            itemsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            itemsListView.Location = new Point(332, 31);
            itemsListView.Margin = new Padding(4, 3, 4, 3);
            itemsListView.MultiSelect = false;
            itemsListView.Name = "itemsListView";
            itemsListView.Size = new Size(271, 384);
            itemsListView.TabIndex = 55;
            itemsListView.UseCompatibleStateImageBehavior = false;
            itemsListView.View = View.Details;
            // 
            // itemsColumn
            // 
            itemsColumn.Text = "Facilities (First is empty)";
            itemsColumn.Width = 265;
            // 
            // addItemButton
            // 
            addItemButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addItemButton.Location = new Point(521, 421);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(38, 24);
            addItemButton.TabIndex = 56;
            addItemButton.Text = "Add";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // delItemButton
            // 
            delItemButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delItemButton.ForeColor = Color.Red;
            delItemButton.Location = new Point(565, 421);
            delItemButton.Name = "delItemButton";
            delItemButton.Size = new Size(38, 24);
            delItemButton.TabIndex = 57;
            delItemButton.Text = "Del";
            delItemButton.UseVisualStyleBackColor = true;
            delItemButton.Click += delItemButton_Click;
            // 
            // itemComboBox
            // 
            itemComboBox.FormattingEnabled = true;
            itemComboBox.Location = new Point(332, 421);
            itemComboBox.Name = "itemComboBox";
            itemComboBox.Size = new Size(183, 23);
            itemComboBox.TabIndex = 58;
            // 
            // groupComboBox
            // 
            groupComboBox.Enabled = false;
            groupComboBox.FormattingEnabled = true;
            groupComboBox.Location = new Point(6, 421);
            groupComboBox.Name = "groupComboBox";
            groupComboBox.Size = new Size(232, 23);
            groupComboBox.TabIndex = 61;
            // 
            // delGroupButton
            // 
            delGroupButton.Enabled = false;
            delGroupButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delGroupButton.ForeColor = Color.Red;
            delGroupButton.Location = new Point(288, 421);
            delGroupButton.Name = "delGroupButton";
            delGroupButton.Size = new Size(38, 24);
            delGroupButton.TabIndex = 60;
            delGroupButton.Text = "Del";
            delGroupButton.UseVisualStyleBackColor = true;
            delGroupButton.Click += delGroupButton_Click;
            // 
            // addGroupButton
            // 
            addGroupButton.Enabled = false;
            addGroupButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addGroupButton.Location = new Point(244, 421);
            addGroupButton.Name = "addGroupButton";
            addGroupButton.Size = new Size(38, 24);
            addGroupButton.TabIndex = 59;
            addGroupButton.Text = "Add";
            addGroupButton.UseVisualStyleBackColor = true;
            addGroupButton.Click += addGroupButton_Click;
            // 
            // groupsDataGridView
            // 
            groupsDataGridView.AllowUserToAddRows = false;
            groupsDataGridView.AllowUserToDeleteRows = false;
            groupsDataGridView.AllowUserToResizeColumns = false;
            groupsDataGridView.AllowUserToResizeRows = false;
            groupsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, groupColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            groupsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            groupsDataGridView.Location = new Point(6, 31);
            groupsDataGridView.Name = "groupsDataGridView";
            groupsDataGridView.RowHeadersVisible = false;
            groupsDataGridView.RowTemplate.Height = 25;
            groupsDataGridView.Size = new Size(322, 384);
            groupsDataGridView.TabIndex = 62;
            groupsDataGridView.SelectionChanged += groupsDataGridView_SelectionChanged;
            // 
            // idColumn
            // 
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Resizable = DataGridViewTriState.False;
            idColumn.Width = 32;
            // 
            // groupColumn
            // 
            groupColumn.HeaderText = "Group";
            groupColumn.Name = "groupColumn";
            groupColumn.ReadOnly = true;
            groupColumn.Resizable = DataGridViewTriState.False;
            groupColumn.Width = 287;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(13, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(262, 15);
            infoLabel.TabIndex = 63;
            infoLabel.Text = "Define here initial Alliance Headquarter facilities.";
            // 
            // AllianceHeadquarterFacilitiesTableForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(609, 486);
            Controls.Add(infoLabel);
            Controls.Add(groupsDataGridView);
            Controls.Add(groupComboBox);
            Controls.Add(delGroupButton);
            Controls.Add(addGroupButton);
            Controls.Add(itemComboBox);
            Controls.Add(delItemButton);
            Controls.Add(addItemButton);
            Controls.Add(itemsListView);
            Controls.Add(openNew);
            Controls.Add(SaveAs);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(625, 525);
            MinimumSize = new Size(625, 525);
            Name = "AllianceHeadquarterFacilitiesTableForm";
            Text = "Alliance Headquarter Facilities Table (FACLHQTB.DAT)";
            Load += GameObjectsListForm_Load;
            ((ISupportInitialize)groupsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView itemsListView;
        private ColumnHeader itemsColumn;
        private Button addItemButton;
        private Button delItemButton;
        private ComboBox itemComboBox;
        private ComboBox groupComboBox;
        private Button delGroupButton;
        private Button addGroupButton;
        private DataGridView groupsDataGridView;
        private Label infoLabel;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn groupColumn;
    }
}