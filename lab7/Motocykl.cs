using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_07
{
    class Motocykl : Pojazd
    {
        public Motocykl() { }

        public Motocykl(string rodzajPojazdu, double masa, int maxPrzyspieszenie, string kolor)
            : base(rodzajPojazdu, masa, maxPrzyspieszenie, kolor) { }

        public override void Akcja(int i)
        {
            if (i == 1)
                Console.WriteLine("Karetka zabrała motocykliste do szpitala.");
            else if (i == 0)
                Console.WriteLine("Najbliższy przechodzień przeniósł motocykliste na chodnik. Po chwili odpoczynku ruszył w dalszą drogę.");
        }

        public override void Reakcja(int i)
        {
            if (i == 1)
                Console.WriteLine("Motocyklista był świadkiem zdarzenia i zadzwonił na policję.");
            else if (i == 0)
                Console.WriteLine("Motocyklista był strasznie sfrustrowany, że maszynista zablokował cały ruch.");
        }
    }
}
