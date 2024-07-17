using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_07
{
    class Pojazd
    {
        protected string rodzajPojazdu;
        protected double masa;
        protected int maxPrzyspieszenie;
        protected string kolor;

        public Pojazd() { }

        public Pojazd(string rodzajPojazdu, double masa, int maxPrzyspieszenie, string kolor)
        {
            this.rodzajPojazdu = rodzajPojazdu;
            this.masa = masa;
            this.maxPrzyspieszenie = maxPrzyspieszenie;
            this.kolor = kolor;
        }

        public virtual void Akcja(int i) { }
        public virtual void Reakcja(int i) { }
    }
}
