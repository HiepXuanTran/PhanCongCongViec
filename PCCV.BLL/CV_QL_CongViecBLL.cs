using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PCCV.Data;
using PCCV.Public;
using System.Data.SqlClient;
using System.Data;
namespace PCCV.BLL
{
    public class CV_QL_CongViecBLL
    {
        CV_QL_CongViecData cls = new CV_QL_CongViecData();
        public DataTable LoadCV_QL_CongViec()
        {
            return cls.LoadCV_QL_CongViec();
        }
        public int CV_QL_CongViec_Del(CV_QL_CongViecPublic Public)
        {
            return cls.CV_QL_CongViec_Del(Public);
        }
        public int CV_QL_CongViec_Add(CV_QL_CongViecPublic Public)
        {
            return cls.CV_QL_CongViec_Add(Public);
        }
        public int CV_QL_CongViec_Edit(CV_QL_CongViecPublic Public)
        {
            return cls.CV_QL_CongViec_Edit(Public);
        }
        public DataTable LoadNhanSu()
        {
            return cls.LoadNhanSu();
        }
    }
}
