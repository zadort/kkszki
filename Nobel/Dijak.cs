using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    class Dij
    {
        public int ev;
        public string tipus;
        public string keresztnev;
        public string vezeteknev;

        public Dij(string sor)
        {
            string[] darabok = sor.Split(';');
            this.ev = Convert.ToInt32(darabok[0]);
            this.tipus = darabok[1];
            this.keresztnev = darabok[2];
            this.vezeteknev = darabok[3];
        }
    }
}
