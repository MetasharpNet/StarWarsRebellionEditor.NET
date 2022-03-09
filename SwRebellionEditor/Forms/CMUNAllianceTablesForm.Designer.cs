using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class CMUNAllianceTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int currIndex;
        private static string shipSelected = "";
        private static int unitType = 0;
        private ListView shipListView;
        private ColumnHeader recordNumCol;
        private ColumnHeader shipCol;
        private ColumnHeader Troops;
        private ColumnHeader Fighters;
        private Button newButton;
        private Button updateButton;
        private Button delButton;
        private Button dupbutton;
        private ColumnHeader percCol;
        private ColumnHeader specOpsCol;
        private GroupBox groupBox1;
        private ComboBox recTypeBox;
        private Button delSpecOpsButton;
        private Button delFighterButton;
        private Button delTroopButton;
        private ComboBox addSpecOpsBox;
        private ComboBox addFighterBox;
        private ComboBox addTroopBox;
        private Label label2;
        private Label label1;
        private NumericUpDown unitPercNum;
        private ComboBox specOpsCargoBox;
        private ComboBox FighterCargoBox;
        private ComboBox troopCargoBox;
        private GroupBox groupBox2;
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private GroupBox shipCargoBox;
        private Label shipSpecOpsLoad;
        private Label shipFighterLoad;
        private Label shipTroopLoad;
        private Label shipSpecOpsLabel;
        private Label shipFighterLabel;
        private Label shipTroopLabel;
        private Button addSpecOpsButton;
        private Button addFighterButton;
        private Button addTroopButton;
        private GroupBox maxCargoBox;
        private Label maxFighterCap;
        private Label maxTroopCap;
        private Label MaxFighterLabel;
        private Label maxTroopLabel;

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
            this.shipListView = new System.Windows.Forms.ListView();
            this.recordNumCol = new System.Windows.Forms.ColumnHeader();
            this.percCol = new System.Windows.Forms.ColumnHeader();
            this.shipCol = new System.Windows.Forms.ColumnHeader();
            this.Troops = new System.Windows.Forms.ColumnHeader();
            this.Fighters = new System.Windows.Forms.ColumnHeader();
            this.specOpsCol = new System.Windows.Forms.ColumnHeader();
            this.newButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.dupbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unitPercNum = new System.Windows.Forms.NumericUpDown();
            this.addSpecOpsBox = new System.Windows.Forms.ComboBox();
            this.addFighterBox = new System.Windows.Forms.ComboBox();
            this.addTroopBox = new System.Windows.Forms.ComboBox();
            this.recTypeBox = new System.Windows.Forms.ComboBox();
            this.delTroopButton = new System.Windows.Forms.Button();
            this.delFighterButton = new System.Windows.Forms.Button();
            this.delSpecOpsButton = new System.Windows.Forms.Button();
            this.specOpsCargoBox = new System.Windows.Forms.ComboBox();
            this.FighterCargoBox = new System.Windows.Forms.ComboBox();
            this.troopCargoBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxCargoBox = new System.Windows.Forms.GroupBox();
            this.maxFighterCap = new System.Windows.Forms.Label();
            this.maxTroopCap = new System.Windows.Forms.Label();
            this.MaxFighterLabel = new System.Windows.Forms.Label();
            this.maxTroopLabel = new System.Windows.Forms.Label();
            this.addSpecOpsButton = new System.Windows.Forms.Button();
            this.addFighterButton = new System.Windows.Forms.Button();
            this.addTroopButton = new System.Windows.Forms.Button();
            this.shipCargoBox = new System.Windows.Forms.GroupBox();
            this.shipSpecOpsLoad = new System.Windows.Forms.Label();
            this.shipFighterLoad = new System.Windows.Forms.Label();
            this.shipTroopLoad = new System.Windows.Forms.Label();
            this.shipSpecOpsLabel = new System.Windows.Forms.Label();
            this.shipFighterLabel = new System.Windows.Forms.Label();
            this.shipTroopLabel = new System.Windows.Forms.Label();
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitPercNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.maxCargoBox.SuspendLayout();
            this.shipCargoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipListView
            // 
            this.shipListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recordNumCol,
            this.percCol,
            this.shipCol,
            this.Troops,
            this.Fighters,
            this.specOpsCol});
            this.shipListView.FullRowSelect = true;
            this.shipListView.GridLines = true;
            this.shipListView.Location = new System.Drawing.Point(14, 1);
            this.shipListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipListView.MultiSelect = false;
            this.shipListView.Name = "shipListView";
            this.shipListView.Size = new System.Drawing.Size(573, 208);
            this.shipListView.TabIndex = 0;
            this.shipListView.UseCompatibleStateImageBehavior = false;
            this.shipListView.View = System.Windows.Forms.View.Details;
            this.shipListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.shipListView_ItemSelectionChanged);
            this.shipListView.Enter += new System.EventHandler(this.shipListView_Enter);
            // 
            // recordNumCol
            // 
            this.recordNumCol.Text = "Rec";
            this.recordNumCol.Width = 32;
            // 
            // percCol
            // 
            this.percCol.Text = "%";
            this.percCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.percCol.Width = 28;
            // 
            // shipCol
            // 
            this.shipCol.Text = "Ship";
            this.shipCol.Width = 255;
            // 
            // Troops
            // 
            this.Troops.Text = "Troops";
            this.Troops.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Troops.Width = 45;
            // 
            // Fighters
            // 
            this.Fighters.Text = "Fighters";
            this.Fighters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fighters.Width = 50;
            // 
            // specOpsCol
            // 
            this.specOpsCol.Text = "SpecOps";
            this.specOpsCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(114, 388);
            this.newButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(88, 27);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(209, 388);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 27);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(303, 388);
            this.delButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(88, 27);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // dupbutton
            // 
            this.dupbutton.Location = new System.Drawing.Point(398, 388);
            this.dupbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dupbutton.Name = "dupbutton";
            this.dupbutton.Size = new System.Drawing.Size(88, 27);
            this.dupbutton.TabIndex = 4;
            this.dupbutton.Text = "Duplicate";
            this.dupbutton.UseVisualStyleBackColor = true;
            this.dupbutton.Click += new System.EventHandler(this.dupbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.unitPercNum);
            this.groupBox1.Controls.Add(this.addSpecOpsBox);
            this.groupBox1.Controls.Add(this.addFighterBox);
            this.groupBox1.Controls.Add(this.addTroopBox);
            this.groupBox1.Controls.Add(this.recTypeBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(208, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Percent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Carrying unit";
            // 
            // unitPercNum
            // 
            this.unitPercNum.Location = new System.Drawing.Point(156, 32);
            this.unitPercNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitPercNum.Name = "unitPercNum";
            this.unitPercNum.Size = new System.Drawing.Size(44, 23);
            this.unitPercNum.TabIndex = 42;
            this.unitPercNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitPercNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // addSpecOpsBox
            // 
            this.addSpecOpsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addSpecOpsBox.FormattingEnabled = true;
            this.addSpecOpsBox.Location = new System.Drawing.Point(22, 137);
            this.addSpecOpsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addSpecOpsBox.Name = "addSpecOpsBox";
            this.addSpecOpsBox.Size = new System.Drawing.Size(178, 23);
            this.addSpecOpsBox.TabIndex = 38;
            // 
            // addFighterBox
            // 
            this.addFighterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addFighterBox.FormattingEnabled = true;
            this.addFighterBox.Location = new System.Drawing.Point(22, 105);
            this.addFighterBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addFighterBox.Name = "addFighterBox";
            this.addFighterBox.Size = new System.Drawing.Size(178, 23);
            this.addFighterBox.TabIndex = 37;
            // 
            // addTroopBox
            // 
            this.addTroopBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTroopBox.FormattingEnabled = true;
            this.addTroopBox.Location = new System.Drawing.Point(22, 72);
            this.addTroopBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addTroopBox.Name = "addTroopBox";
            this.addTroopBox.Size = new System.Drawing.Size(178, 23);
            this.addTroopBox.TabIndex = 36;
            // 
            // recTypeBox
            // 
            this.recTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recTypeBox.FormattingEnabled = true;
            this.recTypeBox.Location = new System.Drawing.Point(2, 32);
            this.recTypeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.recTypeBox.Name = "recTypeBox";
            this.recTypeBox.Size = new System.Drawing.Size(150, 23);
            this.recTypeBox.TabIndex = 35;
            this.recTypeBox.SelectionChangeCommitted += new System.EventHandler(this.recTypeBox_SelectionChangeCommitted);
            // 
            // delTroopButton
            // 
            this.delTroopButton.Location = new System.Drawing.Point(274, 70);
            this.delTroopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delTroopButton.Name = "delTroopButton";
            this.delTroopButton.Size = new System.Drawing.Size(88, 27);
            this.delTroopButton.TabIndex = 39;
            this.delTroopButton.Text = "Delete ";
            this.delTroopButton.UseVisualStyleBackColor = true;
            this.delTroopButton.Click += new System.EventHandler(this.delTroopButton_Click);
            // 
            // delFighterButton
            // 
            this.delFighterButton.Location = new System.Drawing.Point(274, 103);
            this.delFighterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delFighterButton.Name = "delFighterButton";
            this.delFighterButton.Size = new System.Drawing.Size(88, 27);
            this.delFighterButton.TabIndex = 40;
            this.delFighterButton.Text = "Delete ";
            this.delFighterButton.UseVisualStyleBackColor = true;
            this.delFighterButton.Click += new System.EventHandler(this.delFighterButton_Click);
            // 
            // delSpecOpsButton
            // 
            this.delSpecOpsButton.Location = new System.Drawing.Point(274, 135);
            this.delSpecOpsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delSpecOpsButton.Name = "delSpecOpsButton";
            this.delSpecOpsButton.Size = new System.Drawing.Size(88, 27);
            this.delSpecOpsButton.TabIndex = 41;
            this.delSpecOpsButton.Text = "Delete ";
            this.delSpecOpsButton.UseVisualStyleBackColor = true;
            this.delSpecOpsButton.Click += new System.EventHandler(this.delSpecOpsButton_Click);
            // 
            // specOpsCargoBox
            // 
            this.specOpsCargoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specOpsCargoBox.FormattingEnabled = true;
            this.specOpsCargoBox.Location = new System.Drawing.Point(96, 136);
            this.specOpsCargoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.specOpsCargoBox.Name = "specOpsCargoBox";
            this.specOpsCargoBox.Size = new System.Drawing.Size(176, 23);
            this.specOpsCargoBox.TabIndex = 47;
            // 
            // FighterCargoBox
            // 
            this.FighterCargoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FighterCargoBox.FormattingEnabled = true;
            this.FighterCargoBox.Location = new System.Drawing.Point(96, 104);
            this.FighterCargoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FighterCargoBox.Name = "FighterCargoBox";
            this.FighterCargoBox.Size = new System.Drawing.Size(176, 23);
            this.FighterCargoBox.TabIndex = 48;
            // 
            // troopCargoBox
            // 
            this.troopCargoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.troopCargoBox.FormattingEnabled = true;
            this.troopCargoBox.Location = new System.Drawing.Point(96, 72);
            this.troopCargoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopCargoBox.Name = "troopCargoBox";
            this.troopCargoBox.Size = new System.Drawing.Size(176, 23);
            this.troopCargoBox.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxCargoBox);
            this.groupBox2.Controls.Add(this.addSpecOpsButton);
            this.groupBox2.Controls.Add(this.addFighterButton);
            this.groupBox2.Controls.Add(this.addTroopButton);
            this.groupBox2.Controls.Add(this.shipCargoBox);
            this.groupBox2.Controls.Add(this.troopCargoBox);
            this.groupBox2.Controls.Add(this.FighterCargoBox);
            this.groupBox2.Controls.Add(this.delTroopButton);
            this.groupBox2.Controls.Add(this.delFighterButton);
            this.groupBox2.Controls.Add(this.specOpsCargoBox);
            this.groupBox2.Controls.Add(this.delSpecOpsButton);
            this.groupBox2.Location = new System.Drawing.Point(223, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(365, 166);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // maxCargoBox
            // 
            this.maxCargoBox.Controls.Add(this.maxFighterCap);
            this.maxCargoBox.Controls.Add(this.maxTroopCap);
            this.maxCargoBox.Controls.Add(this.MaxFighterLabel);
            this.maxCargoBox.Controls.Add(this.maxTroopLabel);
            this.maxCargoBox.Location = new System.Drawing.Point(2, 14);
            this.maxCargoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxCargoBox.Name = "maxCargoBox";
            this.maxCargoBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxCargoBox.Size = new System.Drawing.Size(150, 52);
            this.maxCargoBox.TabIndex = 51;
            this.maxCargoBox.TabStop = false;
            this.maxCargoBox.Text = "Max Cargo Capacity";
            // 
            // maxFighterCap
            // 
            this.maxFighterCap.AutoSize = true;
            this.maxFighterCap.Location = new System.Drawing.Point(77, 32);
            this.maxFighterCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxFighterCap.Name = "maxFighterCap";
            this.maxFighterCap.Size = new System.Drawing.Size(13, 15);
            this.maxFighterCap.TabIndex = 49;
            this.maxFighterCap.Text = "x";
            // 
            // maxTroopCap
            // 
            this.maxTroopCap.AutoSize = true;
            this.maxTroopCap.Location = new System.Drawing.Point(24, 32);
            this.maxTroopCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxTroopCap.Name = "maxTroopCap";
            this.maxTroopCap.Size = new System.Drawing.Size(13, 15);
            this.maxTroopCap.TabIndex = 48;
            this.maxTroopCap.Text = "x";
            // 
            // MaxFighterLabel
            // 
            this.MaxFighterLabel.AutoSize = true;
            this.MaxFighterLabel.Location = new System.Drawing.Point(57, 15);
            this.MaxFighterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxFighterLabel.Name = "MaxFighterLabel";
            this.MaxFighterLabel.Size = new System.Drawing.Size(49, 15);
            this.MaxFighterLabel.TabIndex = 46;
            this.MaxFighterLabel.Text = "Fighters";
            // 
            // maxTroopLabel
            // 
            this.maxTroopLabel.AutoSize = true;
            this.maxTroopLabel.Location = new System.Drawing.Point(7, 15);
            this.maxTroopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxTroopLabel.Name = "maxTroopLabel";
            this.maxTroopLabel.Size = new System.Drawing.Size(42, 15);
            this.maxTroopLabel.TabIndex = 45;
            this.maxTroopLabel.Text = "Troops";
            // 
            // addSpecOpsButton
            // 
            this.addSpecOpsButton.Location = new System.Drawing.Point(5, 136);
            this.addSpecOpsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addSpecOpsButton.Name = "addSpecOpsButton";
            this.addSpecOpsButton.Size = new System.Drawing.Size(88, 27);
            this.addSpecOpsButton.TabIndex = 53;
            this.addSpecOpsButton.Text = "Add ";
            this.addSpecOpsButton.UseVisualStyleBackColor = true;
            this.addSpecOpsButton.Click += new System.EventHandler(this.addSpecOpsButton_Click);
            // 
            // addFighterButton
            // 
            this.addFighterButton.Location = new System.Drawing.Point(5, 104);
            this.addFighterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addFighterButton.Name = "addFighterButton";
            this.addFighterButton.Size = new System.Drawing.Size(88, 27);
            this.addFighterButton.TabIndex = 52;
            this.addFighterButton.Text = "Add ";
            this.addFighterButton.UseVisualStyleBackColor = true;
            this.addFighterButton.Click += new System.EventHandler(this.addFighterButton_Click);
            // 
            // addTroopButton
            // 
            this.addTroopButton.Location = new System.Drawing.Point(5, 70);
            this.addTroopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addTroopButton.Name = "addTroopButton";
            this.addTroopButton.Size = new System.Drawing.Size(88, 27);
            this.addTroopButton.TabIndex = 51;
            this.addTroopButton.Text = "Add ";
            this.addTroopButton.UseVisualStyleBackColor = true;
            this.addTroopButton.Click += new System.EventHandler(this.addTroopButton_Click);
            // 
            // shipCargoBox
            // 
            this.shipCargoBox.Controls.Add(this.shipSpecOpsLoad);
            this.shipCargoBox.Controls.Add(this.shipFighterLoad);
            this.shipCargoBox.Controls.Add(this.shipTroopLoad);
            this.shipCargoBox.Controls.Add(this.shipSpecOpsLabel);
            this.shipCargoBox.Controls.Add(this.shipFighterLabel);
            this.shipCargoBox.Controls.Add(this.shipTroopLabel);
            this.shipCargoBox.Location = new System.Drawing.Point(160, 14);
            this.shipCargoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipCargoBox.Name = "shipCargoBox";
            this.shipCargoBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipCargoBox.Size = new System.Drawing.Size(198, 52);
            this.shipCargoBox.TabIndex = 50;
            this.shipCargoBox.TabStop = false;
            this.shipCargoBox.Text = "Ship\'s Cargo";
            // 
            // shipSpecOpsLoad
            // 
            this.shipSpecOpsLoad.AutoSize = true;
            this.shipSpecOpsLoad.Location = new System.Drawing.Point(136, 32);
            this.shipSpecOpsLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipSpecOpsLoad.Name = "shipSpecOpsLoad";
            this.shipSpecOpsLoad.Size = new System.Drawing.Size(13, 15);
            this.shipSpecOpsLoad.TabIndex = 50;
            this.shipSpecOpsLoad.Text = "x";
            // 
            // shipFighterLoad
            // 
            this.shipFighterLoad.AutoSize = true;
            this.shipFighterLoad.Location = new System.Drawing.Point(77, 32);
            this.shipFighterLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipFighterLoad.Name = "shipFighterLoad";
            this.shipFighterLoad.Size = new System.Drawing.Size(13, 15);
            this.shipFighterLoad.TabIndex = 49;
            this.shipFighterLoad.Text = "x";
            // 
            // shipTroopLoad
            // 
            this.shipTroopLoad.AutoSize = true;
            this.shipTroopLoad.Location = new System.Drawing.Point(24, 32);
            this.shipTroopLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipTroopLoad.Name = "shipTroopLoad";
            this.shipTroopLoad.Size = new System.Drawing.Size(13, 15);
            this.shipTroopLoad.TabIndex = 48;
            this.shipTroopLoad.Text = "x";
            // 
            // shipSpecOpsLabel
            // 
            this.shipSpecOpsLabel.AutoSize = true;
            this.shipSpecOpsLabel.Location = new System.Drawing.Point(113, 15);
            this.shipSpecOpsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipSpecOpsLabel.Name = "shipSpecOpsLabel";
            this.shipSpecOpsLabel.Size = new System.Drawing.Size(53, 15);
            this.shipSpecOpsLabel.TabIndex = 47;
            this.shipSpecOpsLabel.Text = "SpecOps";
            // 
            // shipFighterLabel
            // 
            this.shipFighterLabel.AutoSize = true;
            this.shipFighterLabel.Location = new System.Drawing.Point(57, 15);
            this.shipFighterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipFighterLabel.Name = "shipFighterLabel";
            this.shipFighterLabel.Size = new System.Drawing.Size(49, 15);
            this.shipFighterLabel.TabIndex = 46;
            this.shipFighterLabel.Text = "Fighters";
            // 
            // shipTroopLabel
            // 
            this.shipTroopLabel.AutoSize = true;
            this.shipTroopLabel.Location = new System.Drawing.Point(7, 15);
            this.shipTroopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipTroopLabel.Name = "shipTroopLabel";
            this.shipTroopLabel.Size = new System.Drawing.Size(42, 15);
            this.shipTroopLabel.TabIndex = 45;
            this.shipTroopLabel.Text = "Troops";
            // 
            // openNew
            // 
            this.openNew.Enabled = false;
            this.openNew.Location = new System.Drawing.Point(492, 435);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 53;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            // 
            // SaveAs
            // 
            this.SaveAs.Enabled = false;
            this.SaveAs.Location = new System.Drawing.Point(398, 435);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 52;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Enabled = false;
            this.Cancel.Location = new System.Drawing.Point(114, 435);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 51;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(20, 435);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 50;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // CMUNAllianceTablesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(602, 470);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dupbutton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.shipListView);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CMUNAllianceTablesForm";
            this.Text = "CM UN Alliance Tables (CMUNALTB.DAT)";
            this.Load += new System.EventHandler(this.Form_CMUNALTB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitPercNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.maxCargoBox.ResumeLayout(false);
            this.maxCargoBox.PerformLayout();
            this.shipCargoBox.ResumeLayout(false);
            this.shipCargoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}