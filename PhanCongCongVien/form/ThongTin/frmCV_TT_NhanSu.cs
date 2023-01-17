using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PCCV.Public;
using PCCV.BLL;

namespace PhanCongCongVien
{
    public partial class frmCV_TT_NhanSu : DevExpress.XtraEditors.XtraForm
    {
        public frmCV_TT_NhanSu()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        bool CV_TT_NhanSuAdd = false;
        bool CV_TT_NhanSuEdit = false;
        CV_TT_NhanSuBLL cls = new CV_TT_NhanSuBLL();

        private void frmCV_TT_NhanSu_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = cls.LoadCV_TT_NhanSu_LoadAll();
            barButtonItem_Luu.Enabled = false;
            barButtonItem_Undo.Enabled = false;
            Lock_Unlock_Control_Input(false);
            Lock_Control_Input_Always();

            // Gán tạm Thông tin người dùng
            BienToanCuc.HT_USER_ID = 2;
            BienToanCuc.HT_USER_Ten = "Chu Đăng Tuấn";
        }

        private void Lock_Unlock_Control_Input(bool Lock_Control) //Khóa và mở khóa điều khiển nhập dữ liệu
        {
            if (BienToanCuc.Lock_NhapDuLieu == true)
            {
                this.CV_TT_NhanSu_MaNhanSu.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_TT_NhanSu_HoTen.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_TT_NhanSu_DonVi.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_TT_NhanSu_NhomThucHien.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_TT_NhanSu_TrinhDo.OptionsColumn.ReadOnly = !Lock_Control;
                this.CV_TT_NhanSu_KhaNangChuyenMon.OptionsColumn.ReadOnly = !Lock_Control;
            }
        }
        //luôn luôn khoá 6 cột cuối
        private void Lock_Control_Input_Always()
        {
            this.HT_USER_Create.OptionsColumn.ReadOnly = true;
            this.HT_USER_Editor.OptionsColumn.ReadOnly = true;
            this.CV_TT_NhanSu_DateCreate.OptionsColumn.ReadOnly = true;
            this.CV_TT_NhanSu_DateEditor.OptionsColumn.ReadOnly = true;
            this.CV_TT_NhanSu_HienThi.OptionsColumn.ReadOnly = true;
            this.CV_TT_NhanSu_HienThi.OptionsColumn.ReadOnly = true;

        }
        // mở khoá nút lưu vs undo
        private void Lock_Unlock_Control(Boolean Lock_Control) //Khóa và mở khóa điều khiển chức năng
        {
            barButtonItem_Refresh.Enabled = Lock_Control;
            barButtonItem_Them.Enabled = Lock_Control;
            barButtonItem_Sua.Enabled = Lock_Control;
            barButtonItem_Xoa.Enabled = Lock_Control;
            barButtonItem_Luu.Enabled = !Lock_Control;
            barButtonItem_Undo.Enabled = !Lock_Control;
        }

        private void barButtonItem_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCV_TT_NhanSu_Load(sender, e);
        }

        private void barButtonItem_Undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CV_TT_NhanSuAdd = false;
            CV_TT_NhanSuEdit = false;
            Lock_Unlock_Control(true);
            Lock_Unlock_Control_Input(false);
        }

        private bool KiemTra_NhapDuLieu()
        {
            CV_TT_NhanSu_bandedGridView.MoveFirst();
            for (int i = 0; i < CV_TT_NhanSu_bandedGridView.RowCount; i++)
            {
                if (Convert.ToBoolean(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellValue(CV_TT_NhanSuChon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_MaNhanSu))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_HienThi)))
                        )
                    )
                {
                    return false;
                }
                CV_TT_NhanSu_bandedGridView.MoveNext();
            }
            return true;
        }
        //trả về dòng đang chọn đầu tiên
        private void TraVe_DongDLChon()
        {
            CV_TT_NhanSu_bandedGridView.MoveFirst();
            for (int i = 0; i < CV_TT_NhanSu_bandedGridView.RowCount; i++)
            {
                if (Convert.ToBoolean(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellValue(CV_TT_NhanSuChon)))
                {
                    break;
                }
                CV_TT_NhanSu_bandedGridView.MoveNext();
            }
        }
        // hàm kiểm tra check ô để sửa
        private bool KiemTra()
        {
            CV_TT_NhanSu_bandedGridView.MoveFirst();
            for (int i = 0; i < CV_TT_NhanSu_bandedGridView.RowCount; i++)
            {
                if (Convert.ToBoolean(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellValue(CV_TT_NhanSuChon)))
                {
                    return true;
                }
                CV_TT_NhanSu_bandedGridView.MoveNext();
            }
            return false;
        }

        private void barButtonItem_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CV_TT_NhanSuAdd = true;
            CV_TT_NhanSuEdit = false;
            CV_TT_NhanSu_bandedGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            Lock_Unlock_Control_Input(true);
            Lock_Unlock_Control(false);
        }

        private void barButtonItem_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (CV_TT_NhanSuAdd == true || CV_TT_NhanSuEdit == true)
                {
                    if (KiemTra() == false || KiemTra_NhapDuLieu() == false)
                    {
                        if (KiemTra() == false)
                        {
                            MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (KiemTra_NhapDuLieu() == false)
                        {
                            MessageBox.Show("Bạn phải điền đủ dữ liệu vào các ô", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // đọc dữ liệu từng dòng
                    CV_TT_NhanSu_bandedGridView.MoveFirst();
                    for (int i = 0; i < CV_TT_NhanSu_bandedGridView.RowCount; i++)
                    {
                        if (Convert.ToBoolean(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellValue(CV_TT_NhanSuChon))) // == true
                        {
                            CV_TT_NhanSuPublic Public = new CV_TT_NhanSuPublic();

                            Public.HT_USER_Create = BienToanCuc.HT_USER_ID;
                            Public.HT_USER_Editor = BienToanCuc.HT_USER_ID;
                            Public.CV_TT_NhanSu_DateCreate = DateTime.Now;
                            Public.CV_TT_NhanSu_DateEditor = DateTime.Now;
                            Public.CV_TT_NhanSu_HienThi = true;
                            Public.CV_TT_NhanSu_SuDung = BienToanCuc.HT_USER_Ten;
                            Public.CV_TT_NhanSu_MaNhanSu = CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_MaNhanSu);
                            Public.CV_TT_NhanSu_HoTen = CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_HoTen);
                            Public.CV_TT_NhanSu_DonVi = CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_DonVi);
                            Public.CV_TT_NhanSu_NhomThucHien = CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_NhomThucHien);
                            Public.CV_TT_NhanSu_TrinhDo = CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_TrinhDo);
                            Public.CV_TT_NhanSu_KhaNangChuyenMon = CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_KhaNangChuyenMon);
                            if (CV_TT_NhanSuAdd == true)
                            {
                                int kq = cls.CV_TT_NhanSu_Add(Public);
                            }

                            if (CV_TT_NhanSuEdit == true)
                            {
                                Public.CV_TT_NhanSu_ID = Convert.ToInt32(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_ID));
                                int kq = cls.CV_TT_NhanSu_Edit(Public);
                            }
                        }
                        CV_TT_NhanSu_bandedGridView.MoveNext();
                    }
                }
                TraVe_DongDLChon(); //Trả về dòng chọn đầu tiên

                frmCV_TT_NhanSu_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ
                CV_TT_NhanSuAdd = false;
                CV_TT_NhanSuEdit = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTra() == false)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check mã công việc xem có chọn đúng dòng có dữ liệu chưa 
            if (string.IsNullOrWhiteSpace(Convert.ToString(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_ID))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                CV_TT_NhanSuAdd = false;
                CV_TT_NhanSuEdit = true;
                Lock_Unlock_Control_Input(true);
                Lock_Unlock_Control(false);
            }
        }

        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kq = -1;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Xoá từng dòng đã check
                CV_TT_NhanSu_bandedGridView.MoveFirst();
                for (int i = 0; i < CV_TT_NhanSu_bandedGridView.RowCount; i++)
                {
                    if (Convert.ToBoolean(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellValue(CV_TT_NhanSuChon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellDisplayText(CV_TT_NhanSu_ID))))
                        {
                            CV_TT_NhanSuPublic Public = new CV_TT_NhanSuPublic();
                            Public.CV_TT_NhanSu_ID = Convert.ToInt32(CV_TT_NhanSu_bandedGridView.GetFocusedRowCellValue(CV_TT_NhanSu_ID));
                            kq = cls.CV_TT_NhanSu_Del(Public);
                        }
                        else
                        {
                            MessageBox.Show("Xin mời chọn lại dữ liệu trên lưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    CV_TT_NhanSu_bandedGridView.MoveNext();
                }
            }
            TraVe_DongDLChon();
            if (kq > 0)
            {
                MessageBox.Show("Xoá Thành Công!");
                frmCV_TT_NhanSu_Load(sender, e);
            }
        }
    }
}