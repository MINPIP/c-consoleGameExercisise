using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppx2
{
    abstract class Unit
    {

       // protected int x;
        public int x { get; set; }
       //protected int y;
        public int y { get; set; }
        public string name { get; set; }
       // private string name;


        public Unit(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

    }
}

