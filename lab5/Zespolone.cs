using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_05_Boguszewski_Dominik
{
    class Zespolone
    {
        private double re, im;
        public double mnoznik { get; set; }

        public Zespolone(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Zespolone()
        {
            this.re = 0.0;
            this.im = 0.0;
        }

        public double Modul
        {
            get
            {
                return Math.Sqrt(re * re + im * im);
            }
        }

        public double Kat
        {
            get
            {
                return Math.Atan2(im, re);
            }
        }

        public double RePart 
        {
            get 
            {
                return re;
            }
            set
            {
                re = value;
            }
        }

        public double ImPart
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }

        public static Zespolone IloczynLiczbaZesp(Zespolone liczba, double b)
        {
            Zespolone Pomoc = new Zespolone();
            Pomoc.re = liczba.re * b;
            Pomoc.im = liczba.im * b;
            return Pomoc;
        }

        public Zespolone IloczynLiczZesp(Zespolone liczba)
        {
            Zespolone Pomoc = new Zespolone();
            Pomoc.re = liczba.re * mnoznik;
            Pomoc.im = liczba.im * mnoznik;
            return Pomoc;
        }

        public static void Menu()
        {
            double lre, lim;
            Console.WriteLine("Podaj część rzeczywistą pierwszej liczby:");
            lre = double.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Podaj część urojoną pierwszej liczby:");
            lim = double.Parse(Console.ReadLine().ToString());
            Zespolone liczba1 = new Zespolone(lre, lim);

            Console.WriteLine("Podaj część rzeczywistą drugiej liczby:");
            lre = double.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Podaj część urojoną drugiej liczby:");
            lim = double.Parse(Console.ReadLine().ToString());
            Zespolone liczba2 = new Zespolone(lre, lim);
            Zespolone liczba3;
            liczba3 = liczba1 + liczba2;
            Console.WriteLine("Suma wynosi: {0:F4} + j {1:F4}.", liczba3.RePart, liczba3.ImPart);
        }

        public static Zespolone operator +(Zespolone l1, Zespolone l2)
        {
            return new Zespolone(l1.re + l2.re, l1.im + l2.im);
        }
    }
}
