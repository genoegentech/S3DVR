namespace S3DVR_Biller_WinForms.Masters
{
    partial class UnitsMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btnSaveUnit = new DevComponents.DotNetBar.ButtonX();
            this.chkIsCompound = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblCompound = new System.Windows.Forms.Label();
            this.txtDisplayName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtUnitID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.txtUnitName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonClientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.btnSaveUnit);
            this.ribbonClientPanel1.Controls.Add(this.chkIsCompound);
            this.ribbonClientPanel1.Controls.Add(this.lblCompound);
            this.ribbonClientPanel1.Controls.Add(this.txtDisplayName);
            this.ribbonClientPanel1.Controls.Add(this.lblDisplayName);
            this.ribbonClientPanel1.Controls.Add(this.txtUnitID);
            this.ribbonClientPanel1.Controls.Add(this.lblUnitID);
            this.ribbonClientPanel1.Controls.Add(this.txtUnitName);
            this.ribbonClientPanel1.Controls.Add(this.lblUnitName);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 28);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(371, 194);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.Class = "";
            this.ribbonClientPanel1.TabIndex = 1;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            // 
            // btnSaveUnit
            // 
            this.btnSaveUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveUnit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUnit.Location = new System.Drawing.Point(267, 135);
            this.btnSaveUnit.Name = "btnSaveUnit";
            this.btnSaveUnit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveUnit.TabIndex = 5;
            this.btnSaveUnit.Text = "Save";
            this.btnSaveUnit.ThemeAware = true;
            this.btnSaveUnit.Click += new System.EventHandler(this.btnSaveUnit_Click);
            // 
            // chkIsCompound
            // 
            this.chkIsCompound.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkIsCompound.BackgroundStyle.Class = "";
            this.chkIsCompound.Location = new System.Drawing.Point(123, 97);
            this.chkIsCompound.Name = "chkIsCompound";
            this.chkIsCompound.Size = new System.Drawing.Size(29, 23);
            this.chkIsCompound.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsCompound.TabIndex = 4;
            // 
            // lblCompound
            // 
            this.lblCompound.AutoSize = true;
            this.lblCompound.BackColor = System.Drawing.Color.Transparent;
            this.lblCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompound.ForeColor = System.Drawing.Color.Black;
            this.lblCompound.Location = new System.Drawing.Point(29, 102);
            this.lblCompound.Name = "lblCompound";
            this.lblCompound.Size = new System.Drawing.Size(66, 13);
            this.lblCompound.TabIndex = 6;
            this.lblCompound.Text = "Compound";
            // 
            // txtDisplayName
            // 
            // 
            // 
            // 
            this.txtDisplayName.Border.Class = "TextBoxBorder";
            this.txtDisplayName.Location = new System.Drawing.Point(126, 71);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(216, 20);
            this.txtDisplayName.TabIndex = 3;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayName.Location = new System.Drawing.Point(27, 73);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(84, 13);
            this.lblDisplayName.TabIndex = 4;
            this.lblDisplayName.Text = "Display Name";
            // 
            // txtUnitID
            // 
            // 
            // 
            // 
            this.txtUnitID.Border.Class = "TextBoxBorder";
            this.txtUnitID.Enabled = false;
            this.txtUnitID.Location = new System.Drawing.Point(126, 19);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(216, 20);
            this.txtUnitID.TabIndex = 1;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.Color.Black;
            this.lblUnitID.Location = new System.Drawing.Point(27, 21);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(20, 13);
            this.lblUnitID.TabIndex = 2;
            this.lblUnitID.Text = "ID";
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.Border.Class = "TextBoxBorder";
            this.txtUnitName.Location = new System.Drawing.Point(126, 45);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(216, 20);
            this.txtUnitName.TabIndex = 2;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.Black;
            this.lblUnitName.Location = new System.Drawing.Point(27, 47);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(39, 13);
            this.lblUnitName.TabIndex = 2;
            this.lblUnitName.Text = "Name";
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(371, 28);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // UnitsMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 222);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnitsMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Units Master";
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private System.Windows.Forms.Label lblUnitName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitName;
        private System.Windows.Forms.Label lblDisplayName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDisplayName;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIsCompound;
        private System.Windows.Forms.Label lblCompound;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitID;
        private System.Windows.Forms.Label lblUnitID;
        private DevComponents.DotNetBar.ButtonX btnSaveUnit;
    }
}