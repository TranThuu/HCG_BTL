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
    }
}
