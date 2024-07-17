using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03_Boguszewski_Dominik
{
    class Mikrofalowka
    {
        public int rocznik = 2015;
        public string firma = "Philips.";
        public double cena = 899.99;

        public void Wypisz()
        {
            Console.Write("Rocznik mikrofalówki to: " + rocznik + "\nFirma Mikrofalówki to: " + firma + "\nCena mikrofalówki to: " + cena);
            Console.WriteLine();
        }

        public void Narysuj()
        {
            Console.WriteLine("+--------------------+");
            Console.WriteLine("| +-----------+      |");
            Console.WriteLine("| |           |  ..  |");
            Console.WriteLine("| |           |  ..  |");
            Console.WriteLine("| +-----------+  ..  |");
            Console.WriteLine("+--------------------+");
        }
    }
}