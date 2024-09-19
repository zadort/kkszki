using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nobel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dij> dijlista = new List<Dij>();
            var sorok = File.ReadAllLines("nobel.csv").Skip(1);

            foreach (var sor in sorok)
            {
                dijlista.Add(new Dij(sor));
            }

            //3. feladat
            foreach (var item in dijlista)
            {
                if (item.keresztnev == "Arthur B." && item.vezeteknev == "McDonald")
                {
                    Console.WriteLine(item.tipus);
                }
            }

            //4. feladat
            foreach (var item in dijlista)
            {
                if (item.ev == 2017 && item.tipus == "irodalmi")
                {
                    Console.WriteLine($"{item.keresztnev} {item.vezeteknev}");
                }
            }

            //5. feladat
            foreach (var item in dijlista)
            {
                if (item.vezeteknev == "" && item.tipus == "béke" && item.ev > 1990)
                {
                    Console.WriteLine($"{item.ev}: {item.keresztnev}");
                }
            }

            //6. feladat
            foreach(var item in dijlista)
            {
                if (item.vezeteknev.Contains("Curie"))
                {
                    Console.WriteLine($"{item.ev}: {item.keresztnev} {item.vezeteknev} ({item.tipus})");
                }
            }

            //7. feladat
            foreach (var item in dijlista)
            {

            }

            //8. feladat
            StreamWriter sw = new StreamWriter("feladat.txt");
            for (int i = dijlista.Count-1; i > 0; i--)
            {
                if (dijlista[i].tipus == "orvosi")
                {
                    sw.WriteLine(dijlista[i].ev+ " " +dijlista[i].keresztnev);
                }
                
            }
            sw.Close();


            Console.ReadLine();
        }
    }
}
