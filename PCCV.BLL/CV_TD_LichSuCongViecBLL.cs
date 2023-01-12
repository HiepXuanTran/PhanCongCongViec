using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PCCV.Public;
using PCCV.Data;
namespace PCCV.BLL
{
    public class CV_TD_LichSuCongViecBLL
    {
        CV_TD_LichSuCongViecData cls = new CV_TD_LichSuCongViecData();
        public DataTable LoadLichSuCongViec_LoadAll()
        {
            return cls.LoadLichSuCongViec_LoadAll();
        }

    }
}
