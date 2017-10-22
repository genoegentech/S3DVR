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
            this.btnSaveUnit = new DevComponents.DotNetBar.ButtonX();
            this.chkIsCompound = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtDisplayName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCompound = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtUnitName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.txtUnitID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // btnSaveUnit
            // 
            this.btnSaveUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveUnit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUnit.Location = new System.Drawing.Point(267, 132);
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
            this.chkIsCompound.Location = new System.Drawing.Point(123, 94);
            this.chkIsCompound.Name = "chkIsCompound";
            this.chkIsCompound.Size = new System.Drawing.Size(29, 23);
            this.chkIsCompound.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsCompound.TabIndex = 4;
            // 
            // txtDisplayName
            // 
            // 
            // 
            // 
            this.txtDisplayName.Border.Class = "TextBoxBorder";
            this.txtDisplayName.Location = new System.Drawing.Point(126, 68);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(216, 20);
            this.txtDisplayName.TabIndex = 3;
            // 
            // lblCompound
            // 
            this.lblCompound.AutoSize = true;
            this.lblCompound.BackColor = System.Drawing.Color.Transparent;
            this.lblCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompound.ForeColor = System.Drawing.Color.Black;
            this.lblCompound.Location = new System.Drawing.Point(29, 99);
            this.lblCompound.Name = "lblCompound";
            this.lblCompound.Size = new System.Drawing.Size(66, 13);
            this.lblCompound.TabIndex = 6;
            this.lblCompound.Text = "Compound";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.Black;
            this.lblUnitName.Location = new System.Drawing.Point(27, 44);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(39, 13);
            this.lblUnitName.TabIndex = 2;
            this.lblUnitName.Text = "Name";
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.Border.Class = "TextBoxBorder";
            this.txtUnitName.Location = new System.Drawing.Point(126, 42);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(216, 20);
            this.txtUnitName.TabIndex = 2;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayName.Location = new System.Drawing.Point(27, 70);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(84, 13);
            this.lblDisplayName.TabIndex = 4;
            this.lblDisplayName.Text = "Display Name";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.Color.Black;
            this.lblUnitID.Location = new System.Drawing.Point(27, 18);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(20, 13);
            this.lblUnitID.TabIndex = 2;
            this.lblUnitID.Text = "ID";
            // 
            // txtUnitID
            // 
            // 
            // 
            // 
            this.txtUnitID.Border.Class = "TextBoxBorder";
            this.txtUnitID.Enabled = false;
            this.txtUnitID.Location = new System.Drawing.Point(126, 16);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(216, 20);
            this.txtUnitID.TabIndex = 1;
            // 
            // UnitsMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 181);
            this.Controls.Add(this.btnSaveUnit);
            this.Controls.Add(this.chkIsCompound);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.lblCompound);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblUnitID);
            this.Controls.Add(this.txtUnitID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UnitsMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Units Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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