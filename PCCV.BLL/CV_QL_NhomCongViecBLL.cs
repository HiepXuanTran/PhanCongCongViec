using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PCCV.Data;
namespace PCCV.BLL
{
    public class CV_QL_NhomCongViecBLL
    {
        CV_QL_NhomCongViecData cls = new CV_QL_NhomCongViecData();
        public DataTable LoadCV_QL_NhomCongViec_LoadAll()
        {
            return cls.LoadCV_QL_NhomCongViec_LoadAll();
        }
    }
}
