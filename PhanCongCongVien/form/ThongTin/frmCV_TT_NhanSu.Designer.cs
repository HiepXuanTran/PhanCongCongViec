namespace PhanCongCongVien
{
    partial class frmCV_TT_NhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCV_TT_NhanSu));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.CV_TT_NhanSu_bandedGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CV_TT_NhanSuChon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CV_TT_NhanSu_MaNhanSu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_HoTen = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_DonVi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_NhomThucHien = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CV_TT_NhanSu_TrinhDo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_KhaNangChuyenMon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.HT_USER_Create = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_DateCreate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.HT_USER_Editor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_DateEditor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_HienThi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CV_TT_NhanSu_SuDung = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Them = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Undo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_In = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CV_TT_NhanSu_bandedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(0, 41);
            this.gridControl1.MainView = this.CV_TT_NhanSu_bandedGridView;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(913, 435);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CV_TT_NhanSu_bandedGridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // CV_TT_NhanSu_bandedGridView
            // 
            this.CV_TT_NhanSu_bandedGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand3,
            this.gridBand2,
            this.gridBand4});
            this.CV_TT_NhanSu_bandedGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.CV_TT_NhanSuChon,
            this.CV_TT_NhanSu_ID,
            this.CV_TT_NhanSu_MaNhanSu,
            this.CV_TT_NhanSu_HoTen,
            this.CV_TT_NhanSu_DonVi,
            this.CV_TT_NhanSu_NhomThucHien,
            this.CV_TT_NhanSu_TrinhDo,
            this.CV_TT_NhanSu_KhaNangChuyenMon,
            this.HT_USER_Create,
            this.CV_TT_NhanSu_DateCreate,
            this.HT_USER_Editor,
            this.CV_TT_NhanSu_DateEditor,
            this.CV_TT_NhanSu_HienThi,
            this.CV_TT_NhanSu_SuDung});
            this.CV_TT_NhanSu_bandedGridView.GridControl = this.gridControl1;
            this.CV_TT_NhanSu_bandedGridView.Name = "CV_TT_NhanSu_bandedGridView";
            this.CV_TT_NhanSu_bandedGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.CV_TT_NhanSu_bandedGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.CV_TT_NhanSu_bandedGridView.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.False;
            this.CV_TT_NhanSu_bandedGridView.OptionsView.ShowAutoFilterRow = true;
            this.CV_TT_NhanSu_bandedGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.Columns.Add(this.CV_TT_NhanSuChon);
            this.gridBand1.Columns.Add(this.CV_TT_NhanSu_ID);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 75;
            // 
            // CV_TT_NhanSuChon
            // 
            this.CV_TT_NhanSuChon.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSuChon.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSuChon.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSuChon.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSuChon.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSuChon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSuChon.Caption = "Chọn";
            this.CV_TT_NhanSuChon.FieldName = "CV_TT_NhanSuChon";
            this.CV_TT_NhanSuChon.Name = "CV_TT_NhanSuChon";
            this.CV_TT_NhanSuChon.Visible = true;
            // 
            // CV_TT_NhanSu_ID
            // 
            this.CV_TT_NhanSu_ID.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_ID.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_ID.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_ID.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_ID.Caption = "ID";
            this.CV_TT_NhanSu_ID.FieldName = "CV_TT_NhanSu_ID";
            this.CV_TT_NhanSu_ID.Name = "CV_TT_NhanSu_ID";
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.gridBand3.AppearanceHeader.BackColor2 = System.Drawing.Color.Aqua;
            this.gridBand3.AppearanceHeader.BorderColor = System.Drawing.Color.Aqua;
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand3.AppearanceHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.gridBand3.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand3.AppearanceHeader.Options.UseBorderColor = true;
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Thông tin chung";
            this.gridBand3.Columns.Add(this.CV_TT_NhanSu_MaNhanSu);
            this.gridBand3.Columns.Add(this.CV_TT_NhanSu_HoTen);
            this.gridBand3.Columns.Add(this.CV_TT_NhanSu_DonVi);
            this.gridBand3.Columns.Add(this.CV_TT_NhanSu_NhomThucHien);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 1;
            this.gridBand3.Width = 412;
            // 
            // CV_TT_NhanSu_MaNhanSu
            // 
            this.CV_TT_NhanSu_MaNhanSu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_MaNhanSu.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_MaNhanSu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CV_TT_NhanSu_MaNhanSu.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_MaNhanSu.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_MaNhanSu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_MaNhanSu.Caption = "Mã Nhân Sự";
            this.CV_TT_NhanSu_MaNhanSu.FieldName = "CV_TT_NhanSu_MaNhanSu";
            this.CV_TT_NhanSu_MaNhanSu.Name = "CV_TT_NhanSu_MaNhanSu";
            this.CV_TT_NhanSu_MaNhanSu.Visible = true;
            this.CV_TT_NhanSu_MaNhanSu.Width = 95;
            // 
            // CV_TT_NhanSu_HoTen
            // 
            this.CV_TT_NhanSu_HoTen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_HoTen.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_HoTen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CV_TT_NhanSu_HoTen.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_HoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_HoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_HoTen.Caption = "Họ Tên";
            this.CV_TT_NhanSu_HoTen.FieldName = "CV_TT_NhanSu_HoTen";
            this.CV_TT_NhanSu_HoTen.Name = "CV_TT_NhanSu_HoTen";
            this.CV_TT_NhanSu_HoTen.Visible = true;
            this.CV_TT_NhanSu_HoTen.Width = 95;
            // 
            // CV_TT_NhanSu_DonVi
            // 
            this.CV_TT_NhanSu_DonVi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_DonVi.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_DonVi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CV_TT_NhanSu_DonVi.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_DonVi.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_DonVi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_DonVi.Caption = "Đơn Vị";
            this.CV_TT_NhanSu_DonVi.FieldName = "CV_TT_NhanSu_DonVi";
            this.CV_TT_NhanSu_DonVi.Name = "CV_TT_NhanSu_DonVi";
            this.CV_TT_NhanSu_DonVi.Visible = true;
            this.CV_TT_NhanSu_DonVi.Width = 102;
            // 
            // CV_TT_NhanSu_NhomThucHien
            // 
            this.CV_TT_NhanSu_NhomThucHien.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_NhomThucHien.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_NhomThucHien.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CV_TT_NhanSu_NhomThucHien.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_NhomThucHien.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_NhomThucHien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_NhomThucHien.Caption = "Nhóm Thực Hiện";
            this.CV_TT_NhanSu_NhomThucHien.FieldName = "CV_TT_NhanSu_NhomThucHien";
            this.CV_TT_NhanSu_NhomThucHien.Name = "CV_TT_NhanSu_NhomThucHien";
            this.CV_TT_NhanSu_NhomThucHien.Visible = true;
            this.CV_TT_NhanSu_NhomThucHien.Width = 120;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.gridBand2.AppearanceHeader.BackColor2 = System.Drawing.Color.Aquamarine;
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.gridBand2.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Chuyên môn";
            this.gridBand2.Columns.Add(this.CV_TT_NhanSu_TrinhDo);
            this.gridBand2.Columns.Add(this.CV_TT_NhanSu_KhaNangChuyenMon);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 200;
            // 
            // CV_TT_NhanSu_TrinhDo
            // 
            this.CV_TT_NhanSu_TrinhDo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_TrinhDo.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_TrinhDo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_TrinhDo.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_TrinhDo.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_TrinhDo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_TrinhDo.Caption = "Trình Độ";
            this.CV_TT_NhanSu_TrinhDo.FieldName = "CV_TT_NhanSu_TrinhDo";
            this.CV_TT_NhanSu_TrinhDo.Name = "CV_TT_NhanSu_TrinhDo";
            this.CV_TT_NhanSu_TrinhDo.Visible = true;
            this.CV_TT_NhanSu_TrinhDo.Width = 57;
            // 
            // CV_TT_NhanSu_KhaNangChuyenMon
            // 
            this.CV_TT_NhanSu_KhaNangChuyenMon.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_KhaNangChuyenMon.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_KhaNangChuyenMon.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CV_TT_NhanSu_KhaNangChuyenMon.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_KhaNangChuyenMon.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_KhaNangChuyenMon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_KhaNangChuyenMon.Caption = "Khả Năng Chuyên Môn";
            this.CV_TT_NhanSu_KhaNangChuyenMon.FieldName = "CV_TT_NhanSu_KhaNangChuyenMon";
            this.CV_TT_NhanSu_KhaNangChuyenMon.Name = "CV_TT_NhanSu_KhaNangChuyenMon";
            this.CV_TT_NhanSu_KhaNangChuyenMon.Visible = true;
            this.CV_TT_NhanSu_KhaNangChuyenMon.Width = 143;
            // 
            // gridBand4
            // 
            this.gridBand4.Columns.Add(this.HT_USER_Create);
            this.gridBand4.Columns.Add(this.CV_TT_NhanSu_DateCreate);
            this.gridBand4.Columns.Add(this.HT_USER_Editor);
            this.gridBand4.Columns.Add(this.CV_TT_NhanSu_DateEditor);
            this.gridBand4.Columns.Add(this.CV_TT_NhanSu_HienThi);
            this.gridBand4.Columns.Add(this.CV_TT_NhanSu_SuDung);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 650;
            // 
            // HT_USER_Create
            // 
            this.HT_USER_Create.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HT_USER_Create.AppearanceCell.Options.UseFont = true;
            this.HT_USER_Create.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.HT_USER_Create.AppearanceHeader.Options.UseFont = true;
            this.HT_USER_Create.AppearanceHeader.Options.UseTextOptions = true;
            this.HT_USER_Create.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HT_USER_Create.Caption = "ID Người tạo";
            this.HT_USER_Create.FieldName = "HT_USER_Create";
            this.HT_USER_Create.Name = "HT_USER_Create";
            this.HT_USER_Create.Visible = true;
            this.HT_USER_Create.Width = 95;
            // 
            // CV_TT_NhanSu_DateCreate
            // 
            this.CV_TT_NhanSu_DateCreate.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_DateCreate.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_DateCreate.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CV_TT_NhanSu_DateCreate.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_DateCreate.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_DateCreate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_DateCreate.Caption = "Ngày tạo";
            this.CV_TT_NhanSu_DateCreate.FieldName = "CV_TT_NhanSu_DateCreate";
            this.CV_TT_NhanSu_DateCreate.Name = "CV_TT_NhanSu_DateCreate";
            this.CV_TT_NhanSu_DateCreate.Visible = true;
            this.CV_TT_NhanSu_DateCreate.Width = 95;
            // 
            // HT_USER_Editor
            // 
            this.HT_USER_Editor.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HT_USER_Editor.AppearanceCell.Options.UseFont = true;
            this.HT_USER_Editor.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.HT_USER_Editor.AppearanceHeader.Options.UseFont = true;
            this.HT_USER_Editor.AppearanceHeader.Options.UseTextOptions = true;
            this.HT_USER_Editor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HT_USER_Editor.Caption = "ID Người sửa";
            this.HT_USER_Editor.FieldName = "HT_USER_Editor";
            this.HT_USER_Editor.Name = "HT_USER_Editor";
            this.HT_USER_Editor.Visible = true;
            this.HT_USER_Editor.Width = 95;
            // 
            // CV_TT_NhanSu_DateEditor
            // 
            this.CV_TT_NhanSu_DateEditor.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_DateEditor.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_DateEditor.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CV_TT_NhanSu_DateEditor.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_DateEditor.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_DateEditor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_DateEditor.Caption = "Ngày sửa";
            this.CV_TT_NhanSu_DateEditor.FieldName = "CV_TT_NhanSu_DateEditor";
            this.CV_TT_NhanSu_DateEditor.Name = "CV_TT_NhanSu_DateEditor";
            this.CV_TT_NhanSu_DateEditor.Visible = true;
            this.CV_TT_NhanSu_DateEditor.Width = 95;
            // 
            // CV_TT_NhanSu_HienThi
            // 
            this.CV_TT_NhanSu_HienThi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_HienThi.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_HienThi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_HienThi.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_HienThi.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_HienThi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_HienThi.Caption = "Hiển Thị";
            this.CV_TT_NhanSu_HienThi.FieldName = "CV_TT_NhanSu_HienThi";
            this.CV_TT_NhanSu_HienThi.Name = "CV_TT_NhanSu_HienThi";
            this.CV_TT_NhanSu_HienThi.Visible = true;
            this.CV_TT_NhanSu_HienThi.Width = 95;
            // 
            // CV_TT_NhanSu_SuDung
            // 
            this.CV_TT_NhanSu_SuDung.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_SuDung.AppearanceCell.Options.UseFont = true;
            this.CV_TT_NhanSu_SuDung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV_TT_NhanSu_SuDung.AppearanceHeader.Options.UseFont = true;
            this.CV_TT_NhanSu_SuDung.AppearanceHeader.Options.UseTextOptions = true;
            this.CV_TT_NhanSu_SuDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CV_TT_NhanSu_SuDung.Caption = "Người tương tác";
            this.CV_TT_NhanSu_SuDung.FieldName = "CV_TT_NhanSu_SuDung";
            this.CV_TT_NhanSu_SuDung.Name = "CV_TT_NhanSu_SuDung";
            this.CV_TT_NhanSu_SuDung.Visible = true;
            this.CV_TT_NhanSu_SuDung.Width = 175;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barButtonItem_Them,
            this.barButtonItem_Sua,
            this.barButtonItem_Xoa,
            this.barButtonItem_Refresh,
            this.barButtonItem5,
            this.barButtonItem_Luu,
            this.barButtonItem_Undo,
            this.barButtonItem_In,
            this.barButtonItem9});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Sua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Luu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_In, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Caption = "Refresh";
            this.barButtonItem_Refresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.Glyph")));
            this.barButtonItem_Refresh.Id = 4;
            this.barButtonItem_Refresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.LargeGlyph")));
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            this.barButtonItem_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Refresh_ItemClick);
            // 
            // barButtonItem_Them
            // 
            this.barButtonItem_Them.Caption = "Thêm";
            this.barButtonItem_Them.Id = 1;
            this.barButtonItem_Them.ImageUri.Uri = "Add";
            this.barButtonItem_Them.Name = "barButtonItem_Them";
            this.barButtonItem_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Them_ItemClick);
            // 
            // barButtonItem_Sua
            // 
            this.barButtonItem_Sua.Caption = "Sửa";
            this.barButtonItem_Sua.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.Glyph")));
            this.barButtonItem_Sua.Id = 2;
            this.barButtonItem_Sua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Sua.LargeGlyph")));
            this.barButtonItem_Sua.Name = "barButtonItem_Sua";
            this.barButtonItem_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Sua_ItemClick);
            // 
            // barButtonItem_Xoa
            // 
            this.barButtonItem_Xoa.Caption = "Xoá";
            this.barButtonItem_Xoa.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Xoa.Glyph")));
            this.barButtonItem_Xoa.Id = 3;
            this.barButtonItem_Xoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Xoa.LargeGlyph")));
            this.barButtonItem_Xoa.Name = "barButtonItem_Xoa";
            this.barButtonItem_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Xoa_ItemClick);
            // 
            // barButtonItem_Luu
            // 
            this.barButtonItem_Luu.Caption = "Lưu";
            this.barButtonItem_Luu.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Luu.Glyph")));
            this.barButtonItem_Luu.Id = 6;
            this.barButtonItem_Luu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Luu.LargeGlyph")));
            this.barButtonItem_Luu.Name = "barButtonItem_Luu";
            this.barButtonItem_Luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Luu_ItemClick);
            // 
            // barButtonItem_Undo
            // 
            this.barButtonItem_Undo.Caption = "Undo";
            this.barButtonItem_Undo.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Undo.Glyph")));
            this.barButtonItem_Undo.Id = 7;
            this.barButtonItem_Undo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Undo.LargeGlyph")));
            this.barButtonItem_Undo.Name = "barButtonItem_Undo";
            this.barButtonItem_Undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Undo_ItemClick);
            // 
            // barButtonItem_In
            // 
            this.barButtonItem_In.Caption = "In";
            this.barButtonItem_In.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_In.Glyph")));
            this.barButtonItem_In.Id = 8;
            this.barButtonItem_In.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_In.LargeGlyph")));
            this.barButtonItem_In.Name = "barButtonItem_In";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(913, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(913, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 476);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(913, 24);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 476);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 476);
            this.panel1.TabIndex = 12;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(913, 41);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "<div align = \"center\">QUẢN LÝ NHÓM CÔNG VIỆC</div>";
            // 
            // frmCV_TT_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCV_TT_NhanSu";
            this.Text = "frmCV_TT_NhanSu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCV_TT_NhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CV_TT_NhanSu_bandedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView CV_TT_NhanSu_bandedGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSuChon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_MaNhanSu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_HoTen;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_DonVi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn HT_USER_Create;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_DateCreate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn HT_USER_Editor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_DateEditor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_HienThi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_SuDung;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Sua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Luu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Undo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_In;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_NhomThucHien;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_TrinhDo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CV_TT_NhanSu_KhaNangChuyenMon;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}