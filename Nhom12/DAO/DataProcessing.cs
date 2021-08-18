using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nhom12.DAO
{
    class DataProcessing
    {
        DBConnection dataConn = new DBConnection();
        public DataTable ShowTable(String sql)
        {
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void ExecuteQuery(String sql)
        {
            dataConn.ExecuteNonQuery(sql);
        }
        public List<String> SelectID(String ID)
        {
            List<String> list = new List<string>();
            String sql = "SELECT * FROM CauHinh WHERE ID LIKE'" + ID + "%'";
            list = dataConn.ExecuteNonQueryList(sql);
            return list;
        }
        public int ExecuteNonQueryNumber(string sql)
        {
            int giaTri = 0;
            SqlConnection conn = dataConn.getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            giaTri = (int)cmd.ExecuteScalar();
            conn.Close();
            return giaTri;

        }
    }
}
