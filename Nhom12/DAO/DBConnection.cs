using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Nhom12.DAO
{
    class DBConnection
    {
        public SqlConnection getConnect()
        {
             String connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TuVanLaptop;Integrated Security=True";
            //String connString = @"Data Source = MCCOMPUTER; Initial Catalog = TuVanLaptop; Integrated Security = True";
            //String connString = @" Data Source=DESKTOP-1EE6NGN\SQLEXPRESS02;Initial Catalog=TuVanLaptop;Integrated Security=True";
            return new SqlConnection(connString);
        }

        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void ExecuteNonQuery(String sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<String> ExecuteNonQueryList(String sql)
        { 
            List < String > lst = new List<String>();
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lst.Add(reader["Description"].ToString());
            }
            conn.Close();
            return lst;
        }
    }
}
