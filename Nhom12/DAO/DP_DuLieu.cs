using Nhom12.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Nhom12.DAO
{
    class DP_DuLieu
    {
        DataProcessing dp = new DataProcessing();

        public List<Luat> listLuat()
        {
            DataTable dt = new DataTable();
            dt = dp.ShowTable("SELECT * FROM Rules");
            List<Luat> lst = new List<Luat>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                Luat tg = new Luat(row["ID"].ToString(), row["VeTrai"].ToString(), row["VePhai"].ToString());
                lst.Add(tg);
            }
            return lst;
        }
    }
}
