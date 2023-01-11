using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace PCCV.Data
{
    public class CV_QL_NhomCongViecData
    {
        clsKetNoi cls = new clsKetNoi();
        public DataTable LoadCV_QL_NhomCongViec_LoadAll()
        {
            return cls.LayDuLieu("CV_QL_NhomCongViec_select");
        }
    }
}
