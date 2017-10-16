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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btnDeleteUnits = new DevComponents.DotNetBar.ButtonX();
            this.btnEditUnits = new DevComponents.DotNetBar.ButtonX();
            this.btnNewUnits = new DevComponents.DotNetBar.ButtonX();
            this.lblUnitsGrid = new System.Windows.Forms.Label();
            this.dgUnitsMastersList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtDisplayName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtUnitName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnitsMastersList)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.btnDeleteUnits);
            this.ribbonClientPanel1.Controls.Add(this.btnEditUnits);
            this.ribbonClientPanel1.Controls.Add(this.btnNewUnits);
            this.ribbonClientPanel1.Controls.Add(this.lblUnitsGrid);
            this.ribbonClientPanel1.Controls.Add(this.dgUnitsMastersList);
            this.ribbonClientPanel1.Controls.Add(this.txtDisplayName);
            this.ribbonClientPanel1.Controls.Add(this.lblDisplayName);
            this.ribbonClientPanel1.Controls.Add(this.lblUnitName);
            this.ribbonClientPanel1.Controls.Add(this.txtUnitName);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 28);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(669, 285);
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
            // btnDeleteUnits
            // 
            this.btnDeleteUnits.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteUnits.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnits.Location = new System.Drawing.Point(501, 243);
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
            this.btnEditUnits.Location = new System.Drawing.Point(420, 243);
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
            this.btnNewUnits.Location = new System.Drawing.Point(582, 243);
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
            this.lblUnitsGrid.Location = new System.Drawing.Point(12, 39);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUnitsMastersList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgUnitsMastersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgUnitsMastersList.Location = new System.Drawing.Point(12, 55);
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
            this.txtDisplayName.Location = new System.Drawing.Point(361, 8);
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
            this.lblDisplayName.Location = new System.Drawing.Point(271, 12);
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
            this.lblUnitName.Location = new System.Drawing.Point(12, 12);
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
            this.txtUnitName.Location = new System.Drawing.Point(59, 8);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(187, 20);
            this.txtUnitName.TabIndex = 0;
            this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
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
            this.ribbonControl1.Size = new System.Drawing.Size(669, 28);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // UnitsMastersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "UnitsMastersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Units Masters List";
            this.Load += new System.EventHandler(this.UnitsMastersList_Load);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnitsMastersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitName;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblUnitsGrid;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgUnitsMastersList;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private DevComponents.DotNetBar.ButtonX btnNewUnits;
        private DevComponents.DotNetBar.ButtonX btnDeleteUnits;
        private DevComponents.DotNetBar.ButtonX btnEditUnits;
    }
}