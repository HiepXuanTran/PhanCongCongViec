namespace PhanCongCongVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLCV_NhanSu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLCV_CongViec = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLCV_PhanCong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLCV_NhomCongViec = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLCV_ChiTietCV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLCV_LichSuCV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QLCV_LichSuNhanSu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem2,
            this.btn_QLCV_NhanSu,
            this.btn_QLCV_CongViec,
            this.btn_QLCV_PhanCong,
            this.btn_QLCV_NhomCongViec,
            this.btn_QLCV_ChiTietCV,
            this.btn_QLCV_LichSuCV,
            this.btn_QLCV_LichSuNhanSu});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1141, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Nhóm công việc";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageUri.Uri = "AlignHorizontalCenter";
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_QLCV_NhanSu
            // 
            this.btn_QLCV_NhanSu.Caption = "Nhân Sự";
            this.btn_QLCV_NhanSu.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_QLCV_NhanSu.Glyph")));
            this.btn_QLCV_NhanSu.Id = 4;
            this.btn_QLCV_NhanSu.Name = "btn_QLCV_NhanSu";
            this.btn_QLCV_NhanSu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_QLCV_NhanSu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_QLCV_CongViec
            // 
            this.btn_QLCV_CongViec.Caption = "Công Việc";
            this.btn_QLCV_CongViec.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_QLCV_CongViec.Glyph")));
            this.btn_QLCV_CongViec.Id = 5;
            this.btn_QLCV_CongViec.Name = "btn_QLCV_CongViec";
            this.btn_QLCV_CongViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_QLCV_CongViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLCV_CongViec_ItemClick);
            // 
            // btn_QLCV_PhanCong
            // 
            this.btn_QLCV_PhanCong.Caption = "Phân công\r\nCông việc- Nhân sự";
            this.btn_QLCV_PhanCong.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_QLCV_PhanCong.Glyph")));
            this.btn_QLCV_PhanCong.Id = 6;
            this.btn_QLCV_PhanCong.Name = "btn_QLCV_PhanCong";
            this.btn_QLCV_PhanCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_QLCV_NhomCongViec
            // 
            this.btn_QLCV_NhomCongViec.Caption = "Nhóm Công Việc";
            this.btn_QLCV_NhomCongViec.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_QLCV_NhomCongViec.Glyph")));
            this.btn_QLCV_NhomCongViec.Id = 7;
            this.btn_QLCV_NhomCongViec.Name = "btn_QLCV_NhomCongViec";
            this.btn_QLCV_NhomCongViec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_QLCV_NhomCongViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLCV_NhomCongViec_ItemClick);
            // 
            // btn_QLCV_ChiTietCV
            // 
            this.btn_QLCV_ChiTietCV.Caption = "Chi Tiết Công Việc";
            this.btn_QLCV_ChiTietCV.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_QLCV_ChiTietCV.Glyph")));
            this.btn_QLCV_ChiTietCV.Id = 8;
            this.btn_QLCV_ChiTietCV.Name = "btn_QLCV_ChiTietCV";
            this.btn_QLCV_ChiTietCV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_QLCV_ChiTietCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLCV_ChiTietCV_ItemClick);
            // 
            // btn_QLCV_LichSuCV
            // 
            this.btn_QLCV_LichSuCV.Caption = "Lịch Sử Công Việc";
            this.btn_QLCV_LichSuCV.Enabled = false;
            this.btn_QLCV_LichSuCV.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_QLCV_LichSuCV.Glyph")));
            this.btn_QLCV_LichSuCV.Id = 9;
            this.btn_QLCV_LichSuCV.Name = "btn_QLCV_LichSuCV";
            this.btn_QLCV_LichSuCV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_QLCV_LichSuCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QLCV_LichSuCV_ItemClick);
            // 
            // btn_QLCV_LichSuNhanSu
            // 
            this.btn_QLCV_LichSuNhanSu.Caption = "Lịch Sử Nhân Sự";
            this.btn_QLCV_LichSuNhanSu.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_QLCV_LichSuNhanSu.Glyph")));
            this.btn_QLCV_LichSuNhanSu.Id = 10;
            this.btn_QLCV_LichSuNhanSu.Name = "btn_QLCV_LichSuNhanSu";
            this.btn_QLCV_LichSuNhanSu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Công việc";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_QLCV_CongViec);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_QLCV_PhanCong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_QLCV_NhomCongViec);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản Lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_QLCV_ChiTietCV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_QLCV_NhanSu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thông Tin";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_QLCV_LichSuCV);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_QLCV_LichSuNhanSu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Theo Dõi";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 518);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1141, 40);
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSelectAttachedControl = true;
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonOnTabsVisible = true;
            this.tabStrip1.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip1.CloseButtonVisible = true;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Location = new System.Drawing.Point(0, 179);
            this.tabStrip1.MdiForm = this;
            this.tabStrip1.MdiTabbedDocuments = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabStrip1.Size = new System.Drawing.Size(1141, 25);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabStrip1.TabIndex = 2;
            this.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabStrip1_SelectedTabChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 558);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevComponents.DotNetBar.TabStrip tabStrip1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_QLCV_NhanSu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_QLCV_CongViec;
        private DevExpress.XtraBars.BarButtonItem btn_QLCV_PhanCong;
        private DevExpress.XtraBars.BarButtonItem btn_QLCV_NhomCongViec;
        private DevExpress.XtraBars.BarButtonItem btn_QLCV_ChiTietCV;
        private DevExpress.XtraBars.BarButtonItem btn_QLCV_LichSuCV;
        private DevExpress.XtraBars.BarButtonItem btn_QLCV_LichSuNhanSu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}