namespace S3DVR_Biller_WinForms.Masters
{
    partial class UnitsMastersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnitsMastersList)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteUnits
            // 
            this.btnDeleteUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnits.Location = new System.Drawing.Point(478, 9);
            this.btnDeleteUnits.Name = "btnDeleteUnits";
            this.btnDeleteUnits.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUnits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteUnits.TabIndex = 6;
            this.btnDeleteUnits.Text = "Delete";
            this.btnDeleteUnits.ThemeAware = true;
            this.btnDeleteUnits.Tooltip = "Delete Selected Unit";
            this.btnDeleteUnits.Click += new System.EventHandler(this.btnDeleteUnits_Click);
            // 
            // btnEditUnits
            // 
            this.btnEditUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUnits.Location = new System.Drawing.Point(397, 9);
            this.btnEditUnits.Name = "btnEditUnits";
            this.btnEditUnits.Size = new System.Drawing.Size(75, 23);
            this.btnEditUnits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditUnits.TabIndex = 6;
            this.btnEditUnits.Text = "Edit";
            this.btnEditUnits.ThemeAware = true;
            this.btnEditUnits.Tooltip = "Edit Selected Unit";
            this.btnEditUnits.Click += new System.EventHandler(this.btnEditUnits_Click);
            // 
            // btnNewUnits
            // 
            this.btnNewUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUnits.Location = new System.Drawing.Point(559, 9);
            this.btnNewUnits.Name = "btnNewUnits";
            this.btnNewUnits.Size = new System.Drawing.Size(75, 23);
            this.btnNewUnits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewUnits.TabIndex = 5;
            this.btnNewUnits.Text = "Add New";
            this.btnNewUnits.ThemeAware = true;
            this.btnNewUnits.Tooltip = "Add New Unit";
            this.btnNewUnits.Click += new System.EventHandler(this.btnNewUnits_Click);
            // 
            // lblUnitsGrid
            // 
            this.lblUnitsGrid.AutoSize = true;
            this.lblUnitsGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitsGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsGrid.ForeColor = System.Drawing.Color.Black;
            this.lblUnitsGrid.Location = new System.Drawing.Point(12, 50);
            this.lblUnitsGrid.Name = "lblUnitsGrid";
            this.lblUnitsGrid.Size = new System.Drawing.Size(102, 13);
            this.lblUnitsGrid.TabIndex = 4;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUnitsMastersList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgUnitsMastersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgUnitsMastersList.Location = new System.Drawing.Point(15, 66);
            this.dgUnitsMastersList.MultiSelect = false;
            this.dgUnitsMastersList.Name = "dgUnitsMastersList";
            this.dgUnitsMastersList.ReadOnly = true;
            this.dgUnitsMastersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUnitsMastersList.Size = new System.Drawing.Size(645, 182);
            this.dgUnitsMastersList.TabIndex = 3;
            // 
            // txtDisplayName
            // 
            // 
            // 
            // 
            this.txtDisplayName.Border.Class = "TextBoxBorder";
            this.txtDisplayName.Location = new System.Drawing.Point(361, 19);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(187, 20);
            this.txtDisplayName.TabIndex = 2;
            this.txtDisplayName.TextChanged += new System.EventHandler(this.txtDisplayName_TextChanged);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayName.Location = new System.Drawing.Point(271, 23);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(84, 13);
            this.lblDisplayName.TabIndex = 1;
            this.lblDisplayName.Text = "Display Name";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.Black;
            this.lblUnitName.Location = new System.Drawing.Point(12, 23);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(39, 13);
            this.lblUnitName.TabIndex = 1;
            this.lblUnitName.Text = "Name";
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.Border.Class = "TextBoxBorder";
            this.txtUnitName.Location = new System.Drawing.Point(59, 19);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(187, 20);
            this.txtUnitName.TabIndex = 0;
            this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnEditUnits);
            this.panelEx1.Controls.Add(this.btnNewUnits);
            this.panelEx1.Controls.Add(this.btnDeleteUnits);
            this.panelEx1.Location = new System.Drawing.Point(15, 254);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(645, 41);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 7;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // UnitsMastersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 313);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.lblUnitsGrid);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.dgUnitsMastersList);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.txtUnitName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UnitsMastersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Units Masters List";
            this.Load += new System.EventHandler(this.UnitsMastersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUnitsMastersList)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitName;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblUnitsGrid;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgUnitsMastersList;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private DevComponents.DotNetBar.ButtonX btnNewUnits;
        private DevComponents.DotNetBar.ButtonX btnDeleteUnits;
        private DevComponents.DotNetBar.ButtonX btnEditUnits;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}