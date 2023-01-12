using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanCongCongVien
{
    class LoadMain
    {
        static frmCV_QL_NhomCongViec m_frmCV_QL_NhomCongViec = null;
        public static void HienThiCV_QL_NhomCongViec()
        {
            if (m_frmCV_QL_NhomCongViec == null || m_frmCV_QL_NhomCongViec.IsDisposed)
            {
                m_frmCV_QL_NhomCongViec = new frmCV_QL_NhomCongViec();
                m_frmCV_QL_NhomCongViec.MdiParent = frmMain.ActiveForm;
                m_frmCV_QL_NhomCongViec.Show();
            }
            else
                m_frmCV_QL_NhomCongViec.Activate();
        }
      //  static frmCV_TD_LichSuCongViec m = null;
    }
    public class BienToanCuc
    {
        public static string CHECK_INTERNET = "google.com.vn";
        public static DateTime Time_Server; //Ngày lấy từ server
        public static DateTime Time_Server_KichHoatDT; //Ngày lấy từ server
        public static string HT_USER_Ten; //Họ tên của người đăng nhập (HT_USER_Ten)
        public static string MaNguoiDung; //Tên đăng nhập
        public static int HT_USER_ID; //ID người đăng nhập   
        public static bool Lock_NhapDuLieu = true;
    }
}
