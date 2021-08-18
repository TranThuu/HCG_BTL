using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
namespace Nhom12.DAO
{
    class DP_Laptop
    {
        DataProcessing daProcess = new DataProcessing();
        DBConnection dbConn = new DBConnection();
        public DataTable showLaptop()
        {
            DataTable dt = new DataTable();
            dt = daProcess.ShowTable("SELECT ID, Name FROM LapTop");
            return dt;
        }
        public DataTable inforLaptop(String ma)
        {
            DataTable dt = new DataTable();
            dt = daProcess.ShowTable("SELECT * FROM LapTop WHERE ID = '"+ma+"'");
            return dt;
        }
        public DataTable showLapTopByID(string id)
        {
            DataTable tbl = new DataTable();
            tbl = daProcess.ShowTable("SELECT ID,Name FROM LapTop WHERE ID = '" + id + "'");
            return tbl;
        }
        public DataTable showLapTopByName(string name)
        {
            DataTable tbl = new DataTable();
            tbl = daProcess.ShowTable("SELECT ID,Name FROM LapTop WHERE Name LIKE '%" + name + "%'");
            return tbl;
        }
        public DataTable insertLapTop(string name, string id)
        {
            DataTable tbl = new DataTable();
            tbl = daProcess.ShowTable("SELECT * FROM LapTop WHERE Name = '" + name + "' AND ID='" + id + "'");
            return tbl;
        }
        //phân trang
        public DataTable showLapTopPaging(int page)
        {
            string sql = "EXEC LapTopPaging '" + page + "'";
            DataTable tbl = new DataTable();
            tbl = daProcess.ShowTable(sql);
            return tbl;
        }
        public int TongLapTop()
        {
            int tong = 0;
            string sql = "SELECT COUNT (*) FROM LapTop";
            tong = daProcess.ExecuteNonQueryNumber(sql);
            return tong;
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        //thêm
        public void themLapTop(string id, string ten, int gia, string cpu, string ram, string oCung, string manHinh, string card,string hdh, string kichThuoc, Image anh)
        {
            SqlConnection conn = dbConn.getConnect();
            conn.Open();
            String sql = " INSERT INTO LapTop  VALUES(N'" + id + "',N'" + ten + "','" + gia + "',N'" + cpu + "',N'" + ram + "',N'" + oCung + "',N'" + manHinh + "',N'" + card + "',N'" + hdh + "',N'" + kichThuoc + "', @Anh)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Anh", ConvertImageToBytes(anh));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaLapTop(string id, string ten, int gia, string cpu, string ram, string oCung, string manHinh, string card, string hdh, string kichThuoc, Image anh)
        {
            SqlConnection conn = dbConn.getConnect();
            conn.Open();
            string sql = "UPDATE LapTop set Name = N'" + ten + "', Price = '" + gia + "', CPU = '" + cpu + "', RAM = '" + ram + "',OCung = '" + oCung + "', ManHinh = N'" + manHinh+ "',CardManHinh = N'" + card + "',HeDieuHanh = '" + hdh + "',KichThuoc = N'" + kichThuoc + "', AnhSP = @Anh where ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Anh", ConvertImageToBytes(anh));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getLapTopById(string ID)
        {
            string sql = "SELECT * FROM LapTop WHERE ID = '"+ID+"'";
            DataTable tbl = new DataTable();
            tbl = daProcess.ShowTable(sql);
            return tbl;
        }
    }
}
