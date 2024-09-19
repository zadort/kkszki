using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> Lista = new List<Class1>();
            var sorok = File.ReadAllLines("domino.txt");
            foreach (var sor in sorok)
            {
                Lista.Add(new Class1(sor));
            }

            foreach (var item in Lista)
            {
                Console.WriteLine($"{item.szam1} {item.szam2}");
            }
            Console.WriteLine($"3. Feladat: Dominók száma:{Lista.Count}db");

            Console.Write("Sorszám: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i] == Lista[sorszam - 1])
                {
                    Console.WriteLine($"4. Feladat: A(z) {sorszam}. sorszámnak megfelelő dominó:{Lista[i].szam1} {Lista[i].szam2}");
                }
            }

            int db = 0;
            foreach (var item in Lista)
            {
                if (item.szam1 == item.szam2)
                {
                    db++;
                }
            }
            Console.WriteLine($"5. Feladat: Dupla dominók száma:{db}db");

            bool joe = true;
            for (int i = 0; i < Lista.Count-1; i++)
            {
                if (Lista[i].szam1 != Lista[i+1].szam2)
                {
                    joe = false;
                }
            }
            Console.WriteLine(joe);
            if (joe)
            {
                Console.WriteLine("6. Feladat: Szabályosak az illesztések");
            }
            else
            {
                Console.WriteLine("6. Feladat: Nem szabályosak az illesztések");
            }

            Console.ReadLine();
        }
    }
}