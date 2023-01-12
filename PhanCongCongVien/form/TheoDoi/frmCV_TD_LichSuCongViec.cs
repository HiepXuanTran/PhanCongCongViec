using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PCCV.BLL;
using PCCV.Public;
namespace PhanCongCongVien.form
{
    public partial class frmCV_TD_LichSuCongViec : Form
    {
        public frmCV_TD_LichSuCongViec()
        {
            InitializeComponent();
        }
        CV_TD_LichSuCongViecBLL cls = new CV_TD_LichSuCongViecBLL();
        private void Lock_Unlock_Control_Input(bool Lock_Control) //Khóa và mở khóa điều khiển nhập dữ liệu
        {
            if (BienToanCuc.Lock_NhapDuLieu == true)
            {
                this.CV_QL_NhomCongViec_TenNhomCongViec1.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_QL_NhomCongViec_TenNhomCongViec2.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_QL_NhomCongViec_TenNhomCongViec2.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_QL_NhomCongViec_MoTa.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_QL_NhomCongViec_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
            }
        }
        //luôn luôn khoá 6 cột cuối
        private void Lock_Control_Input_Always()
        {
            this.HT_USER_Create.OptionsColumn.ReadOnly = true;
            this.HT_USER_Editor.OptionsColumn.ReadOnly = true;
            this.CV_QL_NhomCongViec_DateCreate.OptionsColumn.ReadOnly = true;
            this.CV_QL_NhomCongViec_DateEditor.OptionsColumn.ReadOnly = true;
            this.CV_QL_NhomCongViec_HienThi.OptionsColumn.ReadOnly = true;
            this.CV_QL_NhomCongViec_SuDung.OptionsColumn.ReadOnly = true;

        }
        private void frmCV_TD_LichSuCongViec_Load(object sender, EventArgs e)
        {
            if (BienToanCuc.idCongViec > 0)
            {
                CV_QL_NhomCongViecPublic Public = new CV_QL_NhomCongViecPublic();
                Public.CV_QL_NhomCongViec_ID1 = BienToanCuc.idCongViec;
                gridControl1.DataSource = cls.LoadLichSuCongViec_Load1(Public);
            }
            else
            {
                gridControl1.DataSource = cls.LoadLichSuCongViec_LoadAll();
            }
            Lock_Unlock_Control_Input(false);
            Lock_Control_Input_Always();
            BienToanCuc.HT_USER_ID = 1;
            BienToanCuc.HT_USER_Ten = "Trần Xuân Hiệp";
        }

        private void CV_QL_NhomCongViec_BtnEdit_Click(object sender, EventArgs e)
        {
            frmCV_TD_LichSuCongViec m_frmCV_TD_LichSuCongViec = new frmCV_TD_LichSuCongViec();
            m_frmCV_TD_LichSuCongViec.ShowDialog();
        }
    }
}
