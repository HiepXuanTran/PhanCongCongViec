using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PhanCongCongVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tabStrip1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        //Nút Quản lý công việc 
        private void btn_QLCV_CongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThiCV_QL_CongViec();
        }

        private void btn_QLCV_NhomCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThiCV_QL_NhomCongViec();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void btn_QLCV_NhanSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThiCV_NS_ThongTin();
=======
        private void btn_QLCV_ChiTietCV_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_QLCV_LichSuCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThiCV_TD_LichSuCongViec();
        }

        private void btn_QLCV_PhanCong_ItemClick(object sender, ItemClickEventArgs e)
        {

>>>>>>> fbd2cbb60ce32ac92e1d2d09fce8143fc4c3ca2c
        }
    }
}