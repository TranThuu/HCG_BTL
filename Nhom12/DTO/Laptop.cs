using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom12.DTO
{
    class Laptop
    {
        private String ID;
        private String Name;

        public Laptop()
        {

        }
        public Laptop(string iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
    }
}
