using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    class Class1
    {
        public int szam1;
        public int szam2;

        public Class1(string sor)
        {
            string[] darabok =sor.Split(' ');
            this.szam1 = Convert.ToInt32(darabok[0]);
            this.szam2 = Convert.ToInt32(darabok[1]);
        }
    }
}
