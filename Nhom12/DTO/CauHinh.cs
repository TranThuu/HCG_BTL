using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12.DTO
{
    class CauHinh
    {
        private String ID;
        private String description;

        public CauHinh()
        { 
        }
        public CauHinh(string iD, string description)
        {
            ID = iD;
            this.description = description;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string Description { get => description; set => description = value; }
    }
}
