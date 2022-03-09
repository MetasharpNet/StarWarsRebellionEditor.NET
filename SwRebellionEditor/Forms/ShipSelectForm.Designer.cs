using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class ShipSelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ListBox shipSelList;
        private RadioButton planetRadio1;
        private RadioButton capshipRadio2;
        private Button Cancel;
        private Button Ok;
        private GroupBox puGroupBox;
        private RadioButton puSpecOpsRadio;
        private RadioButton puFighterRadio;
        private RadioButton puTroopRadio;

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
            this.shipSelList = new System.Windows.Forms.ListBox();
            this.planetRadio1 = new System.Windows.Forms.RadioButton();
            this.capshipRadio2 = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.puGroupBox = new System.Windows.Forms.GroupBox();
            this.puSpecOpsRadio = new System.Windows.Forms.RadioButton();
            this.puFighterRadio = new System.Windows.Forms.RadioButton();
            this.puTroopRadio = new System.Windows.Forms.RadioButton();
            this.puGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipSelList
            // 
            this.shipSelList.FormattingEnabled = true;
            this.shipSelList.ItemHeight = 15;
            this.shipSelList.Location = new System.Drawing.Point(131, 46);
            this.shipSelList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipSelList.Name = "shipSelList";
            this.shipSelList.Size = new System.Drawing.Size(129, 229);
            this.shipSelList.TabIndex = 0;
            // 
            // planetRadio1
            // 
            this.planetRadio1.AutoSize = true;
            this.planetRadio1.Location = new System.Drawing.Point(7, 20);
            this.planetRadio1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.planetRadio1.Name = "planetRadio1";
            this.planetRadio1.Size = new System.Drawing.Size(115, 19);
            this.planetRadio1.TabIndex = 1;
            this.planetRadio1.TabStop = true;
            this.planetRadio1.Text = "Planetary System";
            this.planetRadio1.UseVisualStyleBackColor = true;
            this.planetRadio1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // capshipRadio2
            // 
            this.capshipRadio2.AutoSize = true;
            this.capshipRadio2.Location = new System.Drawing.Point(133, 20);
            this.capshipRadio2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.capshipRadio2.Name = "capshipRadio2";
            this.capshipRadio2.Size = new System.Drawing.Size(88, 19);
            this.capshipRadio2.TabIndex = 2;
            this.capshipRadio2.TabStop = true;
            this.capshipRadio2.Text = "Capital Ship";
            this.capshipRadio2.UseVisualStyleBackColor = true;
            this.capshipRadio2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(131, 283);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 54;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(21, 283);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 53;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // puGroupBox
            // 
            this.puGroupBox.Controls.Add(this.puSpecOpsRadio);
            this.puGroupBox.Controls.Add(this.puFighterRadio);
            this.puGroupBox.Controls.Add(this.puTroopRadio);
            this.puGroupBox.Location = new System.Drawing.Point(7, 46);
            this.puGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.puGroupBox.Name = "puGroupBox";
            this.puGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.puGroupBox.Size = new System.Drawing.Size(102, 78);
            this.puGroupBox.TabIndex = 55;
            this.puGroupBox.TabStop = false;
            this.puGroupBox.Text = "Planet Unit";
            // 
            // puSpecOpsRadio
            // 
            this.puSpecOpsRadio.AutoSize = true;
            this.puSpecOpsRadio.Location = new System.Drawing.Point(8, 52);
            this.puSpecOpsRadio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.puSpecOpsRadio.Name = "puSpecOpsRadio";
            this.puSpecOpsRadio.Size = new System.Drawing.Size(71, 19);
            this.puSpecOpsRadio.TabIndex = 2;
            this.puSpecOpsRadio.TabStop = true;
            this.puSpecOpsRadio.Text = "SpecOps";
            this.puSpecOpsRadio.UseVisualStyleBackColor = true;
            // 
            // puFighterRadio
            // 
            this.puFighterRadio.AutoSize = true;
            this.puFighterRadio.Location = new System.Drawing.Point(8, 33);
            this.puFighterRadio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.puFighterRadio.Name = "puFighterRadio";
            this.puFighterRadio.Size = new System.Drawing.Size(62, 19);
            this.puFighterRadio.TabIndex = 1;
            this.puFighterRadio.TabStop = true;
            this.puFighterRadio.Text = "Fighter";
            this.puFighterRadio.UseVisualStyleBackColor = true;
            // 
            // puTroopRadio
            // 
            this.puTroopRadio.AutoSize = true;
            this.puTroopRadio.Location = new System.Drawing.Point(8, 16);
            this.puTroopRadio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.puTroopRadio.Name = "puTroopRadio";
            this.puTroopRadio.Size = new System.Drawing.Size(55, 19);
            this.puTroopRadio.TabIndex = 0;
            this.puTroopRadio.TabStop = true;
            this.puTroopRadio.Text = "Troop";
            this.puTroopRadio.UseVisualStyleBackColor = true;
            // 
            // ShipSelectForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(273, 318);
            this.Controls.Add(this.puGroupBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.capshipRadio2);
            this.Controls.Add(this.planetRadio1);
            this.Controls.Add(this.shipSelList);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(289, 357);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(289, 357);
            this.Name = "ShipSelectForm";
            this.ShowInTaskbar = false;
            this.Text = "Ship Select";
            this.Load += new System.EventHandler(this.Form_ShipSelect_Load);
            this.puGroupBox.ResumeLayout(false);
            this.puGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}