using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12.DAO
{
    class DP_CauHinh
    {
        DataProcessing daProcess = new DataProcessing();
        public DataTable showCauHinh()
        {
            DataTable dt = new DataTable();
            dt = daProcess.ShowTable("SELECT * FROM CauHinh");
            return dt;
        }
        public DataTable showLapTopByID(string id)
        {
            DataTable tbl = new DataTable();
            tbl = daProcess.ShowTable("SELECT ID,Description FROM CauHinh WHERE ID = '" + id + "'");
            return tbl;
        }
    }
}
