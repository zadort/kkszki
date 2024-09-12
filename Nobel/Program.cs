using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach (var item in dijlista)
            {
                Console.WriteLine($"{item.ev} {item.tipus} {item.keresztnev} {item.vezeteknev}");
            }

            Console.ReadLine();
        }
    }
}
