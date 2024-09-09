using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952
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
            this.helyezes = Convert.ToInt32(darabok[0]);
            this.fo = Convert.ToInt32(darabok[1]);
            this.sportag = darabok[2];
            this.versenyszam = darabok[3];
        }
    }
}
