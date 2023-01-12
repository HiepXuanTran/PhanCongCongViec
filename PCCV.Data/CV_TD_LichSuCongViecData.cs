using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PCCV.Public;
namespace PCCV.Data
{
    public class CV_TD_LichSuCongViecData
    {
        clsKetNoi cls = new clsKetNoi();
        public DataTable LoadLichSuCongViec_LoadAll()
        {
            return cls.LayDuLieu("CV_TD_LichSuCongViec_Select");
        }
    }
}
