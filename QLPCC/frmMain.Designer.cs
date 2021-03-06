namespace QLPCC
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDanhMucNha = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDanhMucDat = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTinhPhi = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbDanhMucNha = new System.Windows.Forms.ToolStripButton();
            this.tsbDanhMucDat = new System.Windows.Forms.ToolStripButton();
            this.tsbThoat = new System.Windows.Forms.ToolStripButton();
            this.tsbThemDuong = new System.Windows.Forms.ToolStripButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsbTinhPhi = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.tínhPhíToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDanhMucNha,
            this.itemDanhMucDat,
            this.itemThoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // itemDanhMucNha
            // 
            this.itemDanhMucNha.Name = "itemDanhMucNha";
            this.itemDanhMucNha.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itemDanhMucNha.Size = new System.Drawing.Size(192, 22);
            this.itemDanhMucNha.Text = "Danh mục nhà";
            this.itemDanhMucNha.Click += new System.EventHandler(this.itemDanhMucNha_Click);
            // 
            // itemDanhMucDat
            // 
            this.itemDanhMucDat.Name = "itemDanhMucDat";
            this.itemDanhMucDat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.itemDanhMucDat.Size = new System.Drawing.Size(192, 22);
            this.itemDanhMucDat.Text = "Danh mục đất";
            this.itemDanhMucDat.Click += new System.EventHandler(this.itemDanhMucDat_Click);
            // 
            // itemThoat
            // 
            this.itemThoat.Name = "itemThoat";
            this.itemThoat.Size = new System.Drawing.Size(192, 22);
            this.itemThoat.Text = "Thoát";
            this.itemThoat.Click += new System.EventHandler(this.itemThoat_Click);
            // 
            // tínhPhíToolStripMenuItem
            // 
            this.tínhPhíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTinhPhi});
            this.tínhPhíToolStripMenuItem.Name = "tínhPhíToolStripMenuItem";
            this.tínhPhíToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tínhPhíToolStripMenuItem.Text = "&Tính phí";
            // 
            // itemTinhPhi
            // 
            this.itemTinhPhi.Name = "itemTinhPhi";
            this.itemTinhPhi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.itemTinhPhi.Size = new System.Drawing.Size(177, 22);
            this.itemTinhPhi.Text = "Tính phí CC";
            this.itemTinhPhi.Click += new System.EventHandler(this.itemTinhPhi_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGioiThieu});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ &giúp";
            // 
            // itemGioiThieu
            // 
            this.itemGioiThieu.Name = "itemGioiThieu";
            this.itemGioiThieu.Size = new System.Drawing.Size(129, 22);
            this.itemGioiThieu.Text = "Giới thiệu";
            this.itemGioiThieu.Click += new System.EventHandler(this.itemGioiThieu_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AllowMerge = false;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTinhPhi,
            this.tsbDanhMucNha,
            this.tsbDanhMucDat,
            this.tsbThemDuong,
            this.tsbThoat});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(1016, 31);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tsbDanhMucNha
            // 
            this.tsbDanhMucNha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDanhMucNha.Image = global::QLPCC.Properties.Resources.BPQT1;
            this.tsbDanhMucNha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDanhMucNha.Name = "tsbDanhMucNha";
            this.tsbDanhMucNha.Size = new System.Drawing.Size(28, 28);
            this.tsbDanhMucNha.Text = "Danh mục nhà";
            this.tsbDanhMucNha.ToolTipText = "Danh mục nhà";
            this.tsbDanhMucNha.Click += new System.EventHandler(this.tsbDanhMucNha_Click);
            // 
            // tsbDanhMucDat
            // 
            this.tsbDanhMucDat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDanhMucDat.Image = global::QLPCC.Properties.Resources.ChonNgayLV1;
            this.tsbDanhMucDat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDanhMucDat.Name = "tsbDanhMucDat";
            this.tsbDanhMucDat.Size = new System.Drawing.Size(28, 28);
            this.tsbDanhMucDat.Text = "Danh mục đất";
            this.tsbDanhMucDat.ToolTipText = "Danh mục đất";
            this.tsbDanhMucDat.Click += new System.EventHandler(this.tsbDanhMucDat_Click);
            // 
            // tsbThoat
            // 
            this.tsbThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbThoat.Image = global::QLPCC.Properties.Resources.TruyenLai1;
            this.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThoat.Name = "tsbThoat";
            this.tsbThoat.Size = new System.Drawing.Size(28, 28);
            this.tsbThoat.Text = "Thoát";
            this.tsbThoat.Click += new System.EventHandler(this.tsbThoat_Click);
            // 
            // tsbThemDuong
            // 
            this.tsbThemDuong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbThemDuong.Image = global::QLPCC.Properties.Resources.DanhMuc1;
            this.tsbThemDuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThemDuong.Name = "tsbThemDuong";
            this.tsbThemDuong.Size = new System.Drawing.Size(28, 28);
            this.tsbThemDuong.Text = "Thêm đường";
            this.tsbThemDuong.Click += new System.EventHandler(this.tsbThemDuong_Click);
            // 
            // tsbTinhPhi
            // 
            this.tsbTinhPhi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTinhPhi.Image = global::QLPCC.Properties.Resources.BaoCao1;
            this.tsbTinhPhi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTinhPhi.Name = "tsbTinhPhi";
            this.tsbTinhPhi.Size = new System.Drawing.Size(28, 28);
            this.tsbTinhPhi.Text = "Tính phí";
            this.tsbTinhPhi.Click += new System.EventHandler(this.tsbTinhPhi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1016, 713);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý PCC";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDanhMucNha;
        private System.Windows.Forms.ToolStripMenuItem itemDanhMucDat;
        private System.Windows.Forms.ToolStripMenuItem itemTinhPhi;
        private System.Windows.Forms.ToolStripMenuItem itemGioiThieu;
        private System.Windows.Forms.ToolStripButton tsbTinhPhi;
        private System.Windows.Forms.ToolStripButton tsbThoat;
        private System.Windows.Forms.ToolStripMenuItem itemThoat;
        private System.Windows.Forms.ToolStripButton tsbDanhMucDat;
        private System.Windows.Forms.ToolStripButton tsbDanhMucNha;
        private System.Windows.Forms.ToolStripButton tsbThemDuong;
    }
}



