namespace S3DVR_Biller_WinForms
{
    partial class MDIHomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIHomeForm));
            this.tabMenu = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.tabUsersMenu = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.rBarUnitMasters = new DevComponents.DotNetBar.RibbonBar();
            this.btnRibbonUnitMaster = new DevComponents.DotNetBar.ButtonItem();
            this.brnSampleMaster = new DevComponents.DotNetBar.ButtonItem();
            this.tabMastersMenu = new DevComponents.DotNetBar.TabItem(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager();
            ((System.ComponentModel.ISupportInitialize)(this.tabMenu)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.CanReorderTabs = true;
            this.tabMenu.Controls.Add(this.tabControlPanel2);
            this.tabMenu.Controls.Add(this.tabControlPanel1);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabMenu.SelectedTabIndex = 1;
            this.tabMenu.Size = new System.Drawing.Size(816, 124);
            this.tabMenu.TabIndex = 2;
            this.tabMenu.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabMenu.Tabs.Add(this.tabUsersMenu);
            this.tabMenu.Tabs.Add(this.tabMastersMenu);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.ribbonBar1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(816, 98);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabUsersMenu;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(4, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(161, 84);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            // 
            // tabUsersMenu
            // 
            this.tabUsersMenu.AttachedControl = this.tabControlPanel1;
            this.tabUsersMenu.Name = "tabUsersMenu";
            this.tabUsersMenu.Text = "&Users";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.rBarUnitMasters);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(816, 98);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabMastersMenu;
            // 
            // rBarUnitMasters
            // 
            this.rBarUnitMasters.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rBarUnitMasters.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.rBarUnitMasters.BackgroundStyle.Class = "";
            this.rBarUnitMasters.ContainerControlProcessDialogKey = true;
            this.rBarUnitMasters.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRibbonUnitMaster,
            this.brnSampleMaster});
            this.rBarUnitMasters.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.rBarUnitMasters.Location = new System.Drawing.Point(4, 2);
            this.rBarUnitMasters.MinimumSize = new System.Drawing.Size(150, 87);
            this.rBarUnitMasters.Name = "rBarUnitMasters";
            this.rBarUnitMasters.Size = new System.Drawing.Size(150, 87);
            this.rBarUnitMasters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rBarUnitMasters.TabIndex = 0;
            this.rBarUnitMasters.Text = "Unit Masters";
            // 
            // 
            // 
            this.rBarUnitMasters.TitleStyle.Class = "";
            // 
            // 
            // 
            this.rBarUnitMasters.TitleStyleMouseOver.Class = "";
            // 
            // btnRibbonUnitMaster
            // 
            this.btnRibbonUnitMaster.Icon = ((System.Drawing.Icon)(resources.GetObject("btnRibbonUnitMaster.Icon")));
            this.btnRibbonUnitMaster.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRibbonUnitMaster.Name = "btnRibbonUnitMaster";
            this.btnRibbonUnitMaster.SubItemsExpandWidth = 14;
            this.btnRibbonUnitMaster.Text = "Units";
            this.btnRibbonUnitMaster.Click += new System.EventHandler(this.btnRibbonUnitMaster_Click);
            // 
            // brnSampleMaster
            // 
            this.brnSampleMaster.Name = "brnSampleMaster";
            this.brnSampleMaster.SubItemsExpandWidth = 14;
            this.brnSampleMaster.Text = "SampleMaster";
            this.brnSampleMaster.Click += new System.EventHandler(this.buttonItem14_Click);
            // 
            // tabMastersMenu
            // 
            this.tabMastersMenu.AttachedControl = this.tabControlPanel2;
            this.tabMastersMenu.Name = "tabMastersMenu";
            this.tabMastersMenu.Text = "&Masters";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // MDIHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 424);
            this.Controls.Add(this.tabMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MDIHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S3DVR - Biller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIHomeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabMenu)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar rBarUnitMasters;
        private DevComponents.DotNetBar.ButtonItem btnRibbonUnitMaster;
        private DevComponents.DotNetBar.ButtonItem brnSampleMaster;
        private DevComponents.DotNetBar.TabControl tabMenu;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.TabItem tabUsersMenu;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabMastersMenu;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}