﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class EmpireUnitsTableForm
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
            columnHeader4 = new ColumnHeader();
            addItemButton = new Button();
            delItemButton = new Button();
            itemComboBox = new ComboBox();
            groupComboBox = new ComboBox();
            delGroupButton = new Button();
            addGroupButton = new Button();
            groupsDataGridView = new DataGridView();
            infoLabel = new Label();
            formulaLabel = new Label();
            idColumn = new DataGridViewTextBoxColumn();
            randomTresholdColumn = new DataGridViewTextBoxColumn();
            groupColumn = new DataGridViewTextBoxColumn();
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
            itemsListView.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            itemsListView.FullRowSelect = true;
            itemsListView.GridLines = true;
            itemsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            itemsListView.Location = new Point(332, 44);
            itemsListView.Margin = new Padding(4, 3, 4, 3);
            itemsListView.MultiSelect = false;
            itemsListView.Name = "itemsListView";
            itemsListView.Size = new Size(271, 371);
            itemsListView.TabIndex = 55;
            itemsListView.UseCompatibleStateImageBehavior = false;
            itemsListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Army Units (First is container)";
            columnHeader4.Width = 265;
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
            groupComboBox.FormattingEnabled = true;
            groupComboBox.Location = new Point(6, 421);
            groupComboBox.Name = "groupComboBox";
            groupComboBox.Size = new Size(232, 23);
            groupComboBox.TabIndex = 61;
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
            // groupsDataGridView
            // 
            groupsDataGridView.AllowUserToAddRows = false;
            groupsDataGridView.AllowUserToDeleteRows = false;
            groupsDataGridView.AllowUserToResizeColumns = false;
            groupsDataGridView.AllowUserToResizeRows = false;
            groupsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, randomTresholdColumn, groupColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            groupsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            groupsDataGridView.Location = new Point(6, 44);
            groupsDataGridView.Name = "groupsDataGridView";
            groupsDataGridView.RowHeadersVisible = false;
            groupsDataGridView.RowTemplate.Height = 25;
            groupsDataGridView.Size = new Size(322, 371);
            groupsDataGridView.TabIndex = 62;
            groupsDataGridView.CellValueChanged += groupsDataGridView_CellValueChanged;
            groupsDataGridView.SelectionChanged += groupsDataGridView_SelectionChanged;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(13, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(216, 15);
            infoLabel.TabIndex = 63;
            infoLabel.Text = "Define here initial random Empire units.";
            // 
            // formulaLabel
            // 
            formulaLabel.AutoSize = true;
            formulaLabel.Location = new Point(13, 26);
            formulaLabel.Name = "formulaLabel";
            formulaLabel.Size = new Size(499, 15);
            formulaLabel.TabIndex = 64;
            formulaLabel.Text = "Game rolls 0-100 numbers N. Each creates an army with highest random treshold < N (if any).";
            // 
            // idColumn
            // 
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Resizable = DataGridViewTriState.False;
            idColumn.Width = 32;
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
            // EmpireUnitsTableForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(609, 486);
            Controls.Add(formulaLabel);
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
            Name = "EmpireUnitsTableForm";
            Text = "Empire Units Table (CMUNEMTB.DAT)";
            Load += GameObjectsListForm_Load;
            ((ISupportInitialize)groupsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView itemsListView;
        private ColumnHeader columnHeader4;
        private Button addItemButton;
        private Button delItemButton;
        private ComboBox itemComboBox;
        private ComboBox groupComboBox;
        private Button delGroupButton;
        private Button addGroupButton;
        private DataGridView groupsDataGridView;
        private Label infoLabel;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn randomTresholdColumn;
        private DataGridViewTextBoxColumn groupColumn;
        private Label formulaLabel;
    }
}