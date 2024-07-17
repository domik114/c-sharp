using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_07
{
    class Tramwaj : Pojazd
    {
        public Tramwaj() { }

        public Tramwaj(string rodzajPojazdu, double masa, int maxPrzyspieszenie, string kolor)
            : base(rodzajPojazdu, masa, maxPrzyspieszenie, kolor) { }

        public override void Akcja(int i)
        {
            if (i == 1)
                Console.WriteLine("Maszynista trafił do szpitala, pół miasta zakorkowane.");
            else if (i == 0)
                Console.WriteLine("Maszynista dogadał się z kierowcą pojazdu z którym miał kolizję i pojechali dalej.");
        }

        public override void Reakcja(int i)
        {
            if (i == 1)
                Console.WriteLine("Maszynista zadzwonił po karetkę.");
            else if (i == 0)
                Console.WriteLine("Maszynista widział \"wypadek\" motocyklisty i śmiejąc się do siebie, pojechał dalej.");
        }
    }
}
