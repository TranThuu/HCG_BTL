using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12.DTO
{
    public class GiaiThich
    {
        public Luat r = new Luat();
        public List<String> TG = new List<string>();// chứa các sự kiện nhận giá trị True
        public List<Luat> SAT = new List<Luat>();// chứa các luật thỏa( là luật có vế trái bằng true)
        public List<Luat> R = new List<Luat>();//Tập luật

        public GiaiThich(Luat luat, List<string> tG, List<Luat> sAT, List<Luat> rr)
        {
            r = luat;
            TG = tG;
            SAT = sAT;
            R= rr;
        }
    }
}
