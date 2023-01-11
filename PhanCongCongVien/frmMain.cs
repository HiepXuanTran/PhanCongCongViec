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

        //Nút Quản lý Nhóm công việc 
        private void btn_QLCV_CongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btn_QLCV_NhomCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThiCV_NCV_QuanLy();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}