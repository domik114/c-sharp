using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05_Boguszewski_Dominik
{
    class Piekarnik
    {
        public double ilosc;
        public double gotowka;
        private readonly double cena = 699.99;
        public double moc = 1000;
        public static string model;
        public double Moc { get { return this.moc; } set { this.moc = value; } }
        public static string Model { get { return Piekarnik.model; } set { Piekarnik.model = value; } }

        public static bool operator <(Piekarnik p1, Piekarnik p2)
        {
            return p1.moc < p2.moc;
        }

        public static bool operator >(Piekarnik p1, Piekarnik p2)
        {
            return p1.moc > p2.moc;
        }

        public static Piekarnik operator +(Piekarnik p1, Piekarnik p2)
        {
            return new Piekarnik(p1.moc + p2.moc);
        }

        public Piekarnik() { }

        public Piekarnik(double moc)
        {
            this.moc = moc;
        }

        public Piekarnik(int ilosc, int gotowka)
        {
            this.ilosc = ilosc;
            this.gotowka = gotowka;
        }

        public Piekarnik(Piekarnik kopiowanyPiekarnik)
        {
            this.ilosc = kopiowanyPiekarnik.ilosc;
            this.cena = kopiowanyPiekarnik.cena;
            this.gotowka = kopiowanyPiekarnik.gotowka;
        }

        public static double Dodawanie(double a, double b)
        {
            return a + b;
        }

        public static double ObliczKWH(double m, double g)
        {
            return (m * g) / 1000;
        }

        public void Wypisz()
        {
            Console.WriteLine("{0}; {1}; {2}", this.ilosc, this.gotowka, this.cena);
        }

        public void Policz(double ilosc, double gotowka)
        {
            Console.Clear();
            this.ilosc = ilosc;
            this.gotowka = gotowka;

            double sumaZaPiekarniki = this.cena * this.ilosc;

            if (this.gotowka < sumaZaPiekarniki)
            {
                Console.WriteLine("Masz za mały budżet! Suma za ilość piekarników: {0} a masz {1}.", sumaZaPiekarniki, this.gotowka);
            }
            else if (this.gotowka >= sumaZaPiekarniki)
            {
                double reszta = this.gotowka - sumaZaPiekarniki;
                Console.WriteLine("Zakup będzie udany!: Suma za ilość piekarników: {0} a masz {1}.", sumaZaPiekarniki, this.gotowka);
                Console.WriteLine("Zostanie ci {0} reszty.", reszta);
            }
        }

        public void Policz(double ilosc, ref double gotowka)
        {
            Console.Clear();
            this.ilosc = ilosc;
            this.gotowka = gotowka;

            double sumaZapiekarniki = this.cena * this.ilosc;

            if (this.gotowka < sumaZapiekarniki)
            {
                Console.WriteLine("Masz za mały budżet! Suma za ilość piekarników: {0} a masz {1}.", sumaZapiekarniki, this.gotowka);
            }
            else if (this.gotowka >= sumaZapiekarniki)
            {
                gotowka = this.gotowka - sumaZapiekarniki;
                Console.WriteLine("Zakup będzie udany!: Suma za ilość piekarników: {0} a masz {1}.", sumaZapiekarniki, this.gotowka);
                Console.WriteLine("Zostanie ci {0} reszty.", gotowka);
            }
        }

        public void Policz(out double ilosc, double gotowka)
        {
            Console.Clear();
            ilosc = this.ilosc;
            this.gotowka = gotowka;

            double sumaZaPiekarniki = this.cena * this.ilosc;

            if (this.gotowka < sumaZaPiekarniki)
            {
                Console.WriteLine("Masz za mały budżet! Suma za ilość piekarników: {0} a masz {1}.", sumaZaPiekarniki, this.gotowka);
            }
            else if (this.gotowka >= sumaZaPiekarniki)
            {
                double reszta = this.gotowka - sumaZaPiekarniki;
                Console.WriteLine("Zakup będzie udany!: Suma za ilość piekarników: {0} a masz {1}.", sumaZaPiekarniki, this.gotowka);
                Console.WriteLine("Zostanie ci {0} reszty.", reszta);
            }
        }
    }
}
