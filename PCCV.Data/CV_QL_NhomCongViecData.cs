using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PCCV.Public;
namespace PCCV.Data
{
    public class CV_QL_NhomCongViecData
    {
        clsKetNoi cls = new clsKetNoi();
        public DataTable LoadCV_QL_NhomCongViec_LoadAll()
        {
            return cls.LayDuLieu("CV_QL_NhomCongViec_Select");
        }
        // hàm xoá hiển thị nhóm cv
        public int CV_QL_NhomCongViec_Del(CV_QL_NhomCongViecPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@CV_QL_NhomCongViec_ID";
            giatri[0] = Public.CV_QL_NhomCongViec_ID1;
            return cls.Update("CV_QL_NhomCongViec_Del", bien, giatri, thamso);
        }
        // Thêm công việc 
        public int CV_QL_NhomCongViec_Add(CV_QL_NhomCongViecPublic Public)
        {
            int thamso = 10;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@CV_QL_NhomCongViec_TenNhomCongViec1";
            bien[1] = "@CV_QL_NhomCongViec_TenNhomCongViec2";
            bien[2] = "@CV_QL_NhomCongViec_MoTa";
            bien[3] = "@CV_QL_NhomCongViec_GhiChu";
            bien[4] = "@HT_USER_Create";
            bien[5] = "@CV_QL_NhomCongViec_DateCreate";
            bien[6] = "@HT_USER_Editor";
            bien[7] = "@CV_QL_NhomCongViec_DateEditor";
            bien[8] = "@CV_QL_NhomCongViec_HienThi";
            bien[9] = "@CV_QL_NhomCongViec_SuDung";

            giatri[0] = Public.CV_QL_NhomCongViec_TenNhomCongViec11;
            giatri[1] = Public.CV_QL_NhomCongViec_TenNhomCongViec21;
            giatri[2] = Public.CV_QL_NhomCongViec_MoTa1;
            giatri[3] = Public.CV_QL_NhomCongViec_GhiChu1;
            giatri[4] = Public.HT_USER_Create1;
            giatri[5] = Public.CV_QL_NhomCongViec_DateCreate1;
            giatri[6] = Public.HT_USER_Editor1;
            giatri[7] = Public.CV_QL_NhomCongViec_DateEditor1;
            giatri[8] = Public.CV_QL_NhomCongViec_HienThi1;
            giatri[9] = Public.CV_QL_NhomCongViec_SuDung1;

            return cls.Update("CV_QL_NhomCongViec_Insert", bien, giatri, thamso);
        }
        // Sửa công việc
        public int CV_QL_NhomCongViec_Edit(CV_QL_NhomCongViecPublic Public)
        {
            int thamso = 11;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@CV_QL_NhomCongViec_TenNhomCongViec1";
            bien[1] = "@CV_QL_NhomCongViec_TenNhomCongViec2";
            bien[2] = "@CV_QL_NhomCongViec_MoTa";
            bien[3] = "@CV_QL_NhomCongViec_GhiChu";
            bien[4] = "@HT_USER_Create";
            bien[5] = "@CV_QL_NhomCongViec_DateCreate";
            bien[6] = "@HT_USER_Editor";
            bien[7] = "@CV_QL_NhomCongViec_DateEditor";
            bien[8] = "@CV_QL_NhomCongViec_HienThi";
            bien[9] = "@CV_QL_NhomCongViec_SuDung";
            bien[10] = "@CV_QL_NhomCongViec_ID";

            giatri[0] = Public.CV_QL_NhomCongViec_TenNhomCongViec11;
            giatri[1] = Public.CV_QL_NhomCongViec_TenNhomCongViec21;
            giatri[2] = Public.CV_QL_NhomCongViec_MoTa1;
            giatri[3] = Public.CV_QL_NhomCongViec_GhiChu1;
            giatri[4] = Public.HT_USER_Create1;
            giatri[5] = Public.CV_QL_NhomCongViec_DateCreate1;
            giatri[6] = Public.HT_USER_Editor1;
            giatri[7] = Public.CV_QL_NhomCongViec_DateEditor1;
            giatri[8] = Public.CV_QL_NhomCongViec_HienThi1;
            giatri[9] = Public.CV_QL_NhomCongViec_SuDung1;
            giatri[10] = Public.CV_QL_NhomCongViec_ID1;
            return cls.Update("CV_QL_NhomCongViec_Edit", bien, giatri, thamso);
        }
    }
}
