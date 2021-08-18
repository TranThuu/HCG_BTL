using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Nhom12.DAO
{
    class DP_Luat
    {
        DataProcessing daProcess = new DataProcessing();
        public DataTable showLuat()
        {
            DataTable dt = new DataTable();
            dt = daProcess.ShowTable("SELECT * FROM Rules");
            return dt;
        }
        public void InsertLuat(String ID, String VT, String VP)
        {
            String sql = "INSERT INTO Rules VALUES ('" + ID + "','" + VT + "','" + VP + "')";
            daProcess.ExecuteQuery(sql);
        }
        public void SuaLuat(String ID, String VT, String VP)
        {
            String sql = "UPDATE Rules SET VeTrai = '" + VT + "', VePhai = '" + VP + "' WHERE ID='"+ID+"'";
            daProcess.ExecuteQuery(sql);
        }
    }
}
