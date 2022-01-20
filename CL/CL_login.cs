using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sysproo.CL
{
    class CL_login
    {
      public DataTable login(string id, string pwd)
        {
            DL.CL_dal DL = new DL.CL_dal();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id  ", SqlDbType.VarChar);
            param[0].Value =id;
            param[1] = new SqlParameter("@pwd", SqlDbType.NChar);
            param[1].Value = pwd;
            DL.Open();
            DataTable dt = new DataTable();
            dt = DL.SelectData("loginp", param);
            DL.Close();
            return dt;
        }
    }
}
