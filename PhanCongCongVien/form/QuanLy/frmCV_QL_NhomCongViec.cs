using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCCV.Public;
using PCCV.BLL;
namespace PhanCongCongVien
{
    public partial class frmCV_QL_NhomCongViec : Form
    {
        public frmCV_QL_NhomCongViec()
        {
            InitializeComponent();
        }
        CV_QL_NhomCongViecBLL cls = new CV_QL_NhomCongViecBLL();
        private void frmCV_QL_NhomCongViec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = cls.LoadCV_QL_NhomCongViec_LoadAll();
            barButtonItem_Luu.Enabled = false;
            barButtonItem_Undo.Enabled = false;
            Lock_Unlock_Control_Input(false);
        }
        private void Lock_Unlock_Control_Input(bool Lock_Control) //Khóa và mở khóa điều khiển nhập dữ liệu
        {
            if (BienToanCuc.Lock_NhapDuLieu == true)
            {
                this.CV_QL_NhomCongViecChon.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_QL_NhomCongViec_TenNhomCongViec1.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_QL_NhomCongViec_TenNhomCongViec2.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_QL_NhomCongViec_TenNhomCongViec2.OptionsColumn.ReadOnly = !Lock_Control;
                this.MaSV.OptionsColumn.ReadOnly = !Lock_Control;
                this.HoTen.OptionsColumn.ReadOnly = !Lock_Control;
                this.NgaySinh.OptionsColumn.ReadOnly = !Lock_Control;
                this.Lop.OptionsColumn.ReadOnly = !Lock_Control;
            }
        }
        private void barButtonItem_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
