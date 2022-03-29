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
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.armiesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.unitsListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.capitalShipComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openNew
            // 
            this.openNew.Enabled = false;
            this.openNew.Location = new System.Drawing.Point(506, 447);
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
            this.SaveAs.Location = new System.Drawing.Point(412, 447);
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
            this.Cancel.Location = new System.Drawing.Point(128, 447);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 51;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(34, 447);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 50;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // armiesListView
            // 
            this.armiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.armiesListView.FullRowSelect = true;
            this.armiesListView.GridLines = true;
            this.armiesListView.Location = new System.Drawing.Point(13, 12);
            this.armiesListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.armiesListView.MultiSelect = false;
            this.armiesListView.Name = "armiesListView";
            this.armiesListView.Size = new System.Drawing.Size(328, 368);
            this.armiesListView.TabIndex = 54;
            this.armiesListView.UseCompatibleStateImageBehavior = false;
            this.armiesListView.View = System.Windows.Forms.View.Details;
            this.armiesListView.SelectedIndexChanged += new System.EventHandler(this.armiesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "%";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 28;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Army";
            this.columnHeader3.Width = 255;
            // 
            // unitsListView
            // 
            this.unitsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7});
            this.unitsListView.FullRowSelect = true;
            this.unitsListView.GridLines = true;
            this.unitsListView.Location = new System.Drawing.Point(349, 12);
            this.unitsListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitsListView.MultiSelect = false;
            this.unitsListView.Name = "unitsListView";
            this.unitsListView.Size = new System.Drawing.Size(271, 368);
            this.unitsListView.TabIndex = 55;
            this.unitsListView.UseCompatibleStateImageBehavior = false;
            this.unitsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Type";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(545, 385);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 56;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(545, 414);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 57;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(349, 386);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(190, 23);
            this.unitComboBox.TabIndex = 58;
            // 
            // capitalShipComboBox
            // 
            this.capitalShipComboBox.FormattingEnabled = true;
            this.capitalShipComboBox.Location = new System.Drawing.Point(13, 386);
            this.capitalShipComboBox.Name = "capitalShipComboBox";
            this.capitalShipComboBox.Size = new System.Drawing.Size(190, 23);
            this.capitalShipComboBox.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 59;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CMUNAllianceTablesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(635, 486);
            this.Controls.Add(this.capitalShipComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.unitsListView);
            this.Controls.Add(this.armiesListView);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CMUNAllianceTablesForm";
            this.Text = "CM UN Alliance Tables (CMUNALTB.DAT)";
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView armiesListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView unitsListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader7;
        private Button addButton;
        private Button removeButton;
        private ComboBox unitComboBox;
        private ComboBox capitalShipComboBox;
        private Button button1;
        private Button button2;
    }
}