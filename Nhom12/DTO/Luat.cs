using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12.DTO
{
    public class Luat
    {
        private String ID;
        private String veTrai;
        private String vePhai;


        public Luat()
        {

        }
        public Luat(string iD, string veTrai, string vePhai)
        {
            ID = iD;
            this.veTrai = veTrai;
            this.vePhai = vePhai;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string VeTrai { get => veTrai; set => veTrai = value; }
        public string VePhai { get => vePhai; set => vePhai = value; }
    }
}
