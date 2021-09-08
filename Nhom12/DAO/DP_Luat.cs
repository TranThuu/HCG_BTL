using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Nhom12.DTO;

namespace Nhom12.DAO
{
    class DP_Luat
    {
        static DataProcessing daProcess = new DataProcessing();
        public static List<Luat> listLuat()
        {
            DataTable dt = new DataTable();
            dt = daProcess.ShowTable("SELECT * FROM Rules");
            List<Luat> lst = new List<Luat>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                Luat tg = new Luat(row["ID"].ToString(), row["VeTrai"].ToString(), row["VePhai"].ToString());
                lst.Add(tg);
            }
            return lst;
        }

        public List<Luat> listLuat2()
        {
            DataTable dt = new DataTable();
            dt = daProcess.ShowTable("SELECT * FROM Rules");
            List<Luat> lst = new List<Luat>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                Luat tg = new Luat(row["ID"].ToString(), row["VeTrai"].ToString(), row["VePhai"].ToString());
                lst.Add(tg);
            }
            return lst;
        }

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
        public void XoaLuat(String ID)
        {
            String sql = "DELETE Rules  WHERE ID='" + ID + "'";
            daProcess.ExecuteQuery(sql);
        }

    }
}
