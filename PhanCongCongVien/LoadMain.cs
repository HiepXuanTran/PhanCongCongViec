﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD


=======
using PhanCongCongVien.form;
using PhanCongCongVien.form.QuanLy;
>>>>>>> fbd2cbb60ce32ac92e1d2d09fce8143fc4c3ca2c
namespace PhanCongCongVien
{
    class LoadMain
    {
        // load form hiển thị nhóm công việc
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
<<<<<<< HEAD

        static frmCV_TT_NhanSu m_frmCV_TT_NhanSu = null;
        public static void HienThiCV_NS_ThongTin()
        {
            if (m_frmCV_TT_NhanSu == null || m_frmCV_TT_NhanSu.IsDisposed)
            {
                m_frmCV_TT_NhanSu = new frmCV_TT_NhanSu();
                m_frmCV_TT_NhanSu.MdiParent = frmMain.ActiveForm;
                m_frmCV_TT_NhanSu.Show();
            }
            else
                m_frmCV_TT_NhanSu.Activate();
        }

=======
        // load form hiển thị lịch sử công việc
        static frmCV_TD_LichSuCongViec m_frmCV_TD_LichSuCongViec = null;
        public static void HienThiCV_TD_LichSuCongViec()
        {
            if (m_frmCV_TD_LichSuCongViec == null || m_frmCV_TD_LichSuCongViec.IsDisposed)
            {
                m_frmCV_TD_LichSuCongViec = new frmCV_TD_LichSuCongViec();
                m_frmCV_TD_LichSuCongViec.MdiParent = frmMain.ActiveForm;
                m_frmCV_TD_LichSuCongViec.Show();
            }
            else
                m_frmCV_QL_NhomCongViec.Activate();
        }
        static  frmCV_QL_CongViec m_frmCV_QL_CongViec = null;
        public static void HienThiCV_QL_CongViec()
        {
            if (m_frmCV_QL_CongViec == null || m_frmCV_QL_CongViec.IsDisposed)
            {
                m_frmCV_QL_CongViec = new frmCV_QL_CongViec();
                m_frmCV_QL_CongViec.MdiParent = frmMain.ActiveForm;
                m_frmCV_QL_CongViec.Show();
            }
            else
                m_frmCV_QL_CongViec.Activate();
        }
>>>>>>> fbd2cbb60ce32ac92e1d2d09fce8143fc4c3ca2c
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
        public static int idCongViec = -1;
    }
}
