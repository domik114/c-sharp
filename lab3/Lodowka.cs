using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03_Boguszewski_Dominik
{
    class Lodowka
    {
        public int rocznik = 2019;
        public string firma = "Samsung.";
        public double cena = 699.99;

        public void Wypisz()
        {
            Console.Write("Rocznik lodówki to: " + rocznik + "\nFirma lodówki to: " + firma + "\nCena lodówki to: " + cena);
            Console.WriteLine();
        }

        public void Narysuj()
        {
            Console.WriteLine("+-----------+");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|         | |");
            Console.WriteLine("|         | |");
            Console.WriteLine("|         | |");
            Console.WriteLine("|-----------|");
            Console.WriteLine("|         | |");
            Console.WriteLine("|         | |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("+-----------+");
        }
    }
}