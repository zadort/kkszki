using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace helsinki1952
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Eredmeny> Eredmenylista = new List<Eredmeny>();
            StreamReader sr = new StreamReader("helsinki.txt");
            while (!sr.EndOfStream)
            {
                Eredmenylista.Add(new Eredmeny(sr.ReadLine()));
            }
            sr.Close();
            foreach (var item in Eredmenylista)
            {
                //Console.WriteLine(item.sportag);
            }
            //hány darab eredmény
            Console.WriteLine("A pontszerző helyezések száma: " +Eredmenylista.Count());

            int adb = 0;
            int edb = 0;
            int bdb = 0;
            foreach (var item in Eredmenylista)
            {
                if (item.helyezes==1)
                {
                    adb++;
                }
                if (item.helyezes == 2)
                {
                    edb++;
                }
                if (item.helyezes == 3)
                {
                    bdb++;
                }
            }
            Console.WriteLine("Az aranyérmek száma: "+ adb);
            Console.WriteLine("Az ezüstérmek száma: " + edb);
            Console.WriteLine("A bronzérmek száma: " + bdb);
            Console.WriteLine("Összesen: "+adb+edb+bdb);

            int osszpontszam = 0;
            foreach (var item in Eredmenylista)
            {
                osszpontszam += item.pont();
            }
            Console.WriteLine(osszpontszam);

            int udb = 0;
            int tdb = 0;
            foreach (var item in Eredmenylista)
            {
                if (item.sportag=="uszas" && item.helyezes<4)
                {
                    udb++;
                }
                if (item.sportag == "tdb" && item.helyezes<4)
                {
                    tdb++;
                }
            }
            if (tdb>udb)
            {
                Console.WriteLine("Torna");
            }
            else if (udb>tdb)
            {
                Console.WriteLine("Úszás");
            }
            else
            {
                Console.WriteLine("Egyenlő");
            }




            Console.ReadKey();
        }
    }
}
