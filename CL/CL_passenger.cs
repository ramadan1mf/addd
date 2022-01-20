using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sysproo.CL
{
    class CL_passenger
    {
        public DataTable T_natio()
        {
            DL.CL_dal DL = new DL.CL_dal();
            DataTable dt = new DataTable();
            dt = DL.SelectData("natio.get_all", null);
            DL.Close();
            return dt;
        }
    }
}

