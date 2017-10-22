namespace S3DVR_Biller_WinForms.Masters
{
    partial class MasterSample
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteUnits = new DevComponents.DotNetBar.ButtonX();
            this.btnEditUnits = new DevComponents.DotNetBar.ButtonX();
            this.btnNewUnits = new DevComponents.DotNetBar.ButtonX();
            this.lblUnitsGrid = new System.Windows.Forms.Label();
            this.dgUnitsMastersList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtDisplayName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtUnitName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnitsMastersList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteUnits
            // 
            this.btnDeleteUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnits.Location = new System.Drawing.Point(489, 247);
            this.btnDeleteUnits.Name = "btnDeleteUnits";
            this.btnDeleteUnits.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUnits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteUnits.TabIndex = 14;
            this.btnDeleteUnits.Text = "Delete";
            this.btnDeleteUnits.ThemeAware = true;
            this.btnDeleteUnits.Tooltip = "Delete Selected Unit";
            // 
            // btnEditUnits
            // 
            this.btnEditUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUnits.Location = new System.Drawing.Point(408, 247);
            this.btnEditUnits.Name = "btnEditUnits";
            this.btnEditUnits.Size = new System.Drawing.Size(75, 23);
            this.btnEditUnits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditUnits.TabIndex = 15;
            this.btnEditUnits.Text = "Edit";
            this.btnEditUnits.ThemeAware = true;
            this.btnEditUnits.Tooltip = "Edit Selected Unit";
            // 
            // btnNewUnits
            // 
            this.btnNewUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUnits.Location = new System.Drawing.Point(570, 247);
            this.btnNewUnits.Name = "btnNewUnits";
            this.btnNewUnits.Size = new System.Drawing.Size(75, 23);
            this.btnNewUnits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewUnits.TabIndex = 13;
            this.btnNewUnits.Text = "Add New";
            this.btnNewUnits.ThemeAware = true;
            this.btnNewUnits.Tooltip = "Add New Unit";
            // 
            // lblUnitsGrid
            // 
            this.lblUnitsGrid.AutoSize = true;
            this.lblUnitsGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitsGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsGrid.ForeColor = System.Drawing.Color.Black;
            this.lblUnitsGrid.Location = new System.Drawing.Point(6, 37);
            this.lblUnitsGrid.Name = "lblUnitsGrid";
            this.lblUnitsGrid.Size = new System.Drawing.Size(102, 13);
            this.lblUnitsGrid.TabIndex = 12;
            this.lblUnitsGrid.Text = "Units Master List";
            // 
            // dgUnitsMastersList
            // 
            this.dgUnitsMastersList.AllowUserToAddRows = false;
            this.dgUnitsMastersList.AllowUserToDeleteRows = false;
            this.dgUnitsMastersList.AllowUserToResizeColumns = false;
            this.dgUnitsMastersList.AllowUserToResizeRows = false;
            this.dgUnitsMastersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUnitsMastersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUnitsMastersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgUnitsMastersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgUnitsMastersList.Location = new System.Drawing.Point(6, 53);
            this.dgUnitsMastersList.MultiSelect = false;
            this.dgUnitsMastersList.Name = "dgUnitsMastersList";
            this.dgUnitsMastersList.ReadOnly = true;
            this.dgUnitsMastersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUnitsMastersList.Size = new System.Drawing.Size(645, 182);
            this.dgUnitsMastersList.TabIndex = 11;
            // 
            // txtDisplayName
            // 
            // 
            // 
            // 
            this.txtDisplayName.Border.Class = "TextBoxBorder";
            this.txtDisplayName.Location = new System.Drawing.Point(355, 6);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(187, 20);
            this.txtDisplayName.TabIndex = 10;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayName.Location = new System.Drawing.Point(265, 10);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(84, 13);
            this.lblDisplayName.TabIndex = 8;
            this.lblDisplayName.Text = "Display Name";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.Black;
            this.lblUnitName.Location = new System.Drawing.Point(6, 10);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(39, 13);
            this.lblUnitName.TabIndex = 9;
            this.lblUnitName.Text = "Name";
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.Border.Class = "TextBoxBorder";
            this.txtUnitName.Location = new System.Drawing.Point(53, 6);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(187, 20);
            this.txtUnitName.TabIndex = 7;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Location = new System.Drawing.Point(6, 241);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(645, 33);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 16;
            // 
            // MasterSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 279);
            this.Controls.Add(this.btnDeleteUnits);
            this.Controls.Add(this.btnEditUnits);
            this.Controls.Add(this.btnNewUnits);
            this.Controls.Add(this.lblUnitsGrid);
            this.Controls.Add(this.dgUnitsMastersList);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MasterSample";
            this.Text = "MasterSample";
            ((System.ComponentModel.ISupportInitialize)(this.dgUnitsMastersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDeleteUnits;
        private DevComponents.DotNetBar.ButtonX btnEditUnits;
        private DevComponents.DotNetBar.ButtonX btnNewUnits;
        private System.Windows.Forms.Label lblUnitsGrid;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgUnitsMastersList;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblUnitName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitName;
        private DevComponents.DotNetBar.PanelEx panelEx1;

    }
}