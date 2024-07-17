using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03_Boguszewski_Dominik
{
    class Drzwi
    {
        public int rocznik = 2020;
        public string firma = "Super Drzwi CO.";
        public double cena = 499.99;

        public void Wypisz()
        {
            Console.Write("Rocznik drzwi to: " + rocznik + "\nFirma drzwi to: " + firma + "\nCena drzwi to: " + cena);
            Console.WriteLine();
        }

        public void Narysuj()
        {
            Console.WriteLine("+-----------+");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|        -- |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("+-----------+");
        }
    }
}