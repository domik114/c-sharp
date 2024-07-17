using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05_Boguszewski_Dominik
{
    class Telewizor
    {
        public double ilosc;
        public double gotowka;
        private readonly double cena = 2499.99;
        public double moc = 600;
        public static string model;
        public double Moc { get { return this.moc; } set { this.moc = value; } }
        public static string Model { get { return Telewizor.model; } set { Telewizor.model = value; } }

        public static bool operator <(Telewizor t1, Telewizor t2)
        {
            return t1.moc < t2.moc;
        }

        public static bool operator >(Telewizor t1, Telewizor t2)
        {
            return t1.moc > t2.moc;
        }

        public static Telewizor operator +(Telewizor t1, Telewizor t2)
        {
            return new Telewizor(t1.Moc + t2.Moc);
        }

        public Telewizor() { }

        public Telewizor(double moc)
        {
            this.moc = moc;
        }

        public Telewizor(double ilosc, double gotowka)
        {
            this.ilosc = ilosc;
            this.gotowka = gotowka;
        }

        public Telewizor(Telewizor kopiowanyTelewizor)
        {
            this.ilosc = kopiowanyTelewizor.ilosc;
            this.cena = kopiowanyTelewizor.cena;
            this.gotowka = kopiowanyTelewizor.gotowka;
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

            double sumaZaTelewizory = this.cena * this.ilosc;

            if (this.gotowka < sumaZaTelewizory)
            {
                Console.WriteLine("Masz za mały budżet! Suma za ilość telewizorów: {0} a masz {1}.", sumaZaTelewizory, this.gotowka);
            }
            else if (this.gotowka >= sumaZaTelewizory)
            {
                double reszta = this.gotowka - sumaZaTelewizory;
                Console.WriteLine("Zakup będzie udany!: Suma za ilość telewizorów: {0} a masz {1}.", sumaZaTelewizory, this.gotowka);
                Console.WriteLine("Zostanie ci {0} reszty.", reszta);
            }
        }

        public void Policz(double ilosc, ref double gotowka)
        {
            Console.Clear();
            this.ilosc = ilosc;
            this.gotowka = gotowka;

            double sumaZaTelewizory = this.cena * this.ilosc;

            if (this.gotowka < sumaZaTelewizory)
            {
                Console.WriteLine("Masz za mały budżet! Suma za ilość telewizorów: {0} a masz {1}.", sumaZaTelewizory, this.gotowka);
            }
            else if (this.gotowka >= sumaZaTelewizory)
            {
                gotowka = this.gotowka - sumaZaTelewizory;
                Console.WriteLine("Zakup będzie udany!: Suma za ilość telewizorów: {0} a masz {1}.", sumaZaTelewizory, this.gotowka);
                Console.WriteLine("Zostanie ci {0} reszty.", gotowka);
            }
        }

        public void Policz(out double ilosc, double gotowka)
        {
            Console.Clear();
            ilosc = this.ilosc;
            this.gotowka = gotowka;

            double sumaZaTelewizory = this.cena * ilosc;

            if (this.gotowka < sumaZaTelewizory)
            {
                Console.WriteLine("Masz za mały budżet! Suma za ilość telewizorów: {0} a masz {1}.", sumaZaTelewizory, this.gotowka);
            }
            else if (this.gotowka >= sumaZaTelewizory)
            {
                double reszta = this.gotowka - sumaZaTelewizory;
                Console.WriteLine("Zakup będzie udany!: Suma za ilość telewizorów: {0} a masz {1}.", sumaZaTelewizory, this.gotowka);
                Console.WriteLine("Zostanie ci {0} reszty.", reszta);
            }
        }
    }
}
