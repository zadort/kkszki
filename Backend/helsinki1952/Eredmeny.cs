using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki1952
{
    class Eredmeny
    {
        public int helyezes;
        public int fo;
        public string sportag;
        public string versenyszam;

        public Eredmeny(string sor)
        {
            string[] darabok = sor.Split(' ');

            this.helyezes =Convert.ToInt32( darabok[0]);
            this.fo = Convert.ToInt32(darabok[1]);
            this.sportag = darabok[2];
            this.versenyszam = darabok[3];
        }
        public int pont() {
            int ertek = 0;
            switch (this.helyezes)
            {
                case 1: ertek = 7; break;
                case 2: ertek = 5; break;
                case 3: ertek = 4; break;
                case 4: ertek = 3; break;
                case 5: ertek = 2; break;
                case 6: ertek = 1; break;
            }
            return ertek;
        }



    }
}
