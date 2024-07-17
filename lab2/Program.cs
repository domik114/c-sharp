using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_02_Boguszewski_Dominik
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zawody = new string[5] { 
                "Mechanik",
                "Lekarz",
                "Kierowca",
                "Informatyk",
                "Nauczyciel"
            };
            double[] punkty = new double[5];

            for (int i = 0; i < 5; i++)
                punkty[i] = 0.0;

            int wartosc;

            Pytania(0);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] = wartosc * 0.3;
                punkty[1] = wartosc * 0.3;
                punkty[2] = wartosc * 0.3;
                punkty[3] = wartosc * 1;
                punkty[4] = wartosc * 1.5;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(0);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] = wartosc * 0.3;
                punkty[1] = wartosc * 0.3;
                punkty[2] = wartosc * 0.3;
                punkty[3] = wartosc * 1;
                punkty[4] = wartosc * 1.5;
            }

            Pytania(1);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.2;
                punkty[3] += wartosc * 1.5;
                punkty[4] += wartosc * 0.3;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(1);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.2;
                punkty[3] += wartosc * 1.5;
                punkty[4] += wartosc * 0.3;
            }

            Pytania(2);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 1.5;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(2);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 1.5;
            }

            Pytania(3);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.2;
                punkty[2] += wartosc * 1.5;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(3);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.2;
                punkty[2] += wartosc * 1.5;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }

            Pytania(4);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 1.5;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(4);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 1.5;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }

            Pytania(5);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 1.5;
                punkty[4] += wartosc * 0.3;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(5);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 1.5;
                punkty[4] += wartosc * 0.3;
            }

            Pytania(6);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 1.5;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(6);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 1.5;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }

            Pytania(7);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.6;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 1.5;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(7);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 0.6;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 1.5;
            }

            Pytania(8);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.7;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 1.5;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(8);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.7;
                punkty[1] += wartosc * 0.3;
                punkty[2] += wartosc * 1.5;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }

            Pytania(9);
            wartosc = int.Parse(Console.ReadLine().ToString());
            if ((wartosc >= 1) && (wartosc <= 10))
            {
                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 1.5;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }
            else
            {
                while ((wartosc < 1) || (wartosc > 10))
                {
                    Console.WriteLine("Wartosc wykracza poza przedział. Podaj wartość jeszcze raz:");
                    Pytania(9);
                    wartosc = int.Parse(Console.ReadLine().ToString());
                }

                punkty[0] += wartosc * 0.3;
                punkty[1] += wartosc * 1.5;
                punkty[2] += wartosc * 0.3;
                punkty[3] += wartosc * 0.3;
                punkty[4] += wartosc * 0.3;
            }

            double max = punkty[0];
            int pomocnicza = 0;

            for (int i = 0; i < 5; i++)
            {
                if (punkty[i] > max)
                {
                    max = punkty[i];
                    pomocnicza = i;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Preferowanym zawodem dla ciebie jest {0}", zawody[pomocnicza]);

            Console.ReadKey();
        }

        static void Pytania(int a)
        {
            int linie = 0;
            string sciezka = @"test.txt";
            if (!File.Exists(sciezka))
            {
                Console.WriteLine("Nie odnaleziono pliku.");
            }
            else
            {
                // otwarcie pliku
                using (StreamReader SR = File.OpenText(sciezka))
                {
                    string s;
                    while ((s = SR.ReadLine()) != null)
                    {
                        if (a == linie)
                            Console.WriteLine(s);
                        linie++;
                    }
                }
            }
        }
    }
}