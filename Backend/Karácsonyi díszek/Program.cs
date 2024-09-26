using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsonyCLI
{
    class Osztaly
    {
        public int nap;
        public int elkeszitettHarang;
        public int eladatottHarang;
        public int elkeszitettAngyal;
        public int eladatottAngyal;
        public int elkeszitettFa;
        public int eladottFa;

        public Osztaly(string sor)
        {
            string[] darabok = sor.Split(';');
            int nap = Convert.ToInt32(darabok[0]);
            int elkeszitettHarang = Convert.ToInt32(darabok[1]);
            int eladottHarang = Convert.ToInt32(darabok[2]);
            int elkeszitettAngyal = Convert.ToInt32(darabok[3]);
            int eladottAngyal = Convert.ToInt32(darabok[4]);
            int elkeszitettFa = Convert.ToInt32(darabok[5]);
            int eladottFa = Convert.ToInt32(darabok[6]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //3. feladat
            List < Osztaly > lista = new List<Osztaly>();
            var sorok = File.ReadAllLines("diszek.txt");
            foreach (var sor in sorok)
            {
                lista.Add(new Osztaly(sor));

            }

            //4. feladat
            Console.WriteLine(lista.Count);

            //5. feladat
            bool a;
            bool b;
            foreach (var item in lista)
            {
                if (item.nap == 0)
                {
                    a = true;
                }
                else
                {
                    b = false;

                }
            }
            if (a = true)
            {
                Console.WriteLine("Van");
            }
            else
            {
                Console.WriteLine("Nincs");
            }

            //6. feladat
            while (true)
            {
                try
                {
                    Console.WriteLine("Adj meg egy 1 és 40 közé eső számot");
                    int szam = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Nem érvényes érték!");
                }
            }
            
            

            Console.ReadLine();
        }
    }
}
