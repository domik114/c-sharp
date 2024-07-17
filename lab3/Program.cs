using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03_Boguszewski_Dominik
{
    class Program
    {
        static void Main(string[] args)
        {
            Mikrofalowka mikrofalowka = new Mikrofalowka();
            Drzwi drzwi = new Drzwi();
            Lodowka lodowka = new Lodowka();

            int wybor;

            do
            {
                Console.WriteLine("+--------------------------------------------------+");
                Console.WriteLine("| Wybierz przedmiot domowy, który chcesz zobaczyć: |");
                Console.WriteLine("| 1. Mikrofalówka.                                 |");
                Console.WriteLine("| 2. Drzwi.                                        |");
                Console.WriteLine("| 3. Lodówka.                                      |");
                Console.WriteLine("| 4. Wyjście.                                      |");
                Console.WriteLine("+--------------------------------------------------+");
                Console.WriteLine();

                wybor = int.Parse(Console.ReadLine().ToString());
                Console.WriteLine();

                if (wybor == 1)
                {
                    do
                    {
                        Console.WriteLine("+---------------------------------+");
                        Console.WriteLine("| 1. Pokaż rocznik mikrofalówki.  |");
                        Console.WriteLine("| 2. Pokaż firmę mikrofalówki.    |");
                        Console.WriteLine("| 3. Pokaż cenę mikrofalówki.     |");
                        Console.WriteLine("| 4. Pokaż wszystko z powyższych. |");
                        Console.WriteLine("| 5. Narysuj.                     |");
                        Console.WriteLine("| 6. Cofnij.                      |");
                        Console.WriteLine("+---------------------------------+");
                        Console.WriteLine();

                        wybor = int.Parse(Console.ReadLine().ToString());
                        Console.WriteLine();

                        if (wybor == 1)
                            Console.WriteLine("Rocznik mikrofalówki to: " + mikrofalowka.rocznik + "\n");
                        else if (wybor == 2)
                            Console.WriteLine("Firma mikrofalówki to: " + mikrofalowka.firma + "\n");
                        else if (wybor == 3)
                            Console.WriteLine("Cena mikrofalówki to: " + mikrofalowka.cena + "\n");
                        else if (wybor == 4)
                        {
                            mikrofalowka.Wypisz(); 
                            Console.WriteLine();
                        }
                        else if (wybor == 5)
                        {
                            mikrofalowka.Narysuj(); 
                            Console.WriteLine();
                        }
                        else if (wybor < 1 || wybor > 6)
                            Console.WriteLine("Liczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                    } while (wybor != 6);
                }
                else if (wybor == 2)
                {
                    do
                    {
                        Console.WriteLine("+---------------------------------+");
                        Console.WriteLine("| 1. Pokaż rocznik drzwi.         |");
                        Console.WriteLine("| 2. Pokaż firmę drzwi.           |");
                        Console.WriteLine("| 3. Pokaż cenę drzwi.            |");
                        Console.WriteLine("| 4. Pokaż wszystko z powyższych. |");
                        Console.WriteLine("| 5. Narysuj.                     |");
                        Console.WriteLine("| 6. Cofnij.                      |");
                        Console.WriteLine("+---------------------------------+");
                        Console.WriteLine();

                        wybor = int.Parse(Console.ReadLine().ToString());
                        Console.WriteLine();

                        if (wybor == 1)
                            Console.WriteLine("Rocznik drzwi to: " + drzwi.rocznik + "\n");
                        else if (wybor == 2)
                            Console.WriteLine("Firma drzwi to: " + drzwi.firma + "\n");
                        else if (wybor == 3)
                            Console.WriteLine("Cena drzwi to: " + drzwi.cena + "\n");
                        else if (wybor == 4)
                        {
                            drzwi.Wypisz(); 
                            Console.WriteLine();
                        }
                        else if (wybor == 5)
                        {
                            drzwi.Narysuj();
                            Console.WriteLine();
                        }
                        else if (wybor < 1 || wybor > 6)
                            Console.WriteLine("Liczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                    } while (wybor != 6);
                }
                else if (wybor == 3)
                {
                    do
                    {
                        Console.WriteLine("+---------------------------------+");
                        Console.WriteLine("| 1. Pokaż rocznik lodówki.       |");
                        Console.WriteLine("| 2. Pokaż firmę lodówki.         |");
                        Console.WriteLine("| 3. Pokaż cenę lodówki.          |");
                        Console.WriteLine("| 4. Pokaż wszystko z powyższych. |");
                        Console.WriteLine("| 5. Narysuj.                     |");
                        Console.WriteLine("| 6. Cofnij.                      |");
                        Console.WriteLine("+---------------------------------+");
                        Console.WriteLine();

                        wybor = int.Parse(Console.ReadLine().ToString());
                        Console.WriteLine();

                        if (wybor == 1)
                            Console.WriteLine("Rocznik lodówki to: " + lodowka.rocznik + "\n");
                        else if (wybor == 2)
                            Console.WriteLine("Firma lodówki to: " + lodowka.firma + "\n");
                        else if (wybor == 3)
                            Console.WriteLine("Cena lodówki to: " + lodowka.cena + "\n");
                        else if (wybor == 4)
                        {
                            lodowka.Wypisz(); 
                            Console.WriteLine();
                        }
                        else if (wybor == 5)
                        {
                            lodowka.Narysuj(); 
                            Console.WriteLine();
                        }
                        else if (wybor < 1 || wybor > 6)
                            Console.WriteLine("Liczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                    } while (wybor != 6);
                }
                else if (wybor < 1 || wybor > 4)
                    Console.WriteLine("Liczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
            } while (wybor != 4);
        }
    }
}