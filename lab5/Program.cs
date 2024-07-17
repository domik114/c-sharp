using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_05_Boguszewski_Dominik
{
    class Program
    {
        static void Main(string[] args)
        {
            Telewizor telewizor = new Telewizor(5, 5);
            Piekarnik piekarnik = new Piekarnik(1, 1);
            Telewizor telewizor2 = new Telewizor();

            int wybor = 0;
            double gotowka = 0;
            double ilosc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Wybierz przedmiot lub wyjdź.");
                Console.WriteLine("1. Telewizor.");
                Console.WriteLine("2. Piekarnik.");
                Console.WriteLine("3. Kopiowanie.");
                Console.WriteLine("4. Zadanie 6.");
                Console.WriteLine("5. Zadanie 6 - lab.");
                Console.WriteLine("6. Wyjdź.");
                Console.WriteLine();

                do
                {
                    try
                    {
                        wybor = int.Parse(Console.ReadLine());
                        if (wybor < 1 || wybor > 6)
                            Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                    }
                    catch
                    {
                        Console.WriteLine("\nBłędny znak!\n");                        
                    }
                } while (wybor < 1 || wybor > 6);

                if (wybor == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1. Argumenty przekazywane przez wartość.");
                        Console.WriteLine("2. Argumenty przekazywane przez referencję.");
                        Console.WriteLine("3. Argumenty przekazywane przez wyjście.");
                        Console.WriteLine("4. Cofnij.");
                        Console.WriteLine();

                        do
                        {
                            try
                            {
                                wybor = int.Parse(Console.ReadLine());
                                if (wybor < 1 || wybor > 4)
                                    Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                            }
                            catch
                            {
                                Console.WriteLine("\nBłędny znak!\n");
                            }
                        } while (wybor < 1 || wybor > 4);

                        if (wybor == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile chcesz kupić telewizorów:");
                            Console.WriteLine();

                            do
                            {
                                try
                                {
                                    ilosc = int.Parse(Console.ReadLine());
                                    if (ilosc < 0 || ilosc > 100)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (ilosc == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (ilosc <= 0 || ilosc > 100);

                            Console.WriteLine("\nPodaj ile masz dostępnej gotówki.");
                            do
                            {
                                try
                                {
                                    gotowka = int.Parse(Console.ReadLine());
                                    if (gotowka < 0 || gotowka > 1000000)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (gotowka == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (gotowka <= 0 || gotowka > 1000000);

                            telewizor.Policz(ilosc, gotowka);

                            Console.WriteLine("{0} - gotówka, {1} - ilosc.", gotowka, ilosc);

                            Console.WriteLine("\n1.Cofnij");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);

                            wybor = 0;
                        }
                        else if (wybor == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile chcesz kupić telewizorów:");
                            Console.WriteLine();

                            do
                            {
                                try
                                {
                                    ilosc = int.Parse(Console.ReadLine());
                                    if (ilosc < 0 || ilosc > 100)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (ilosc == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (ilosc <= 0 || ilosc > 100);

                            Console.WriteLine("\nPodaj ile masz dostępnej gotówki.");
                            do
                            {
                                try
                                {
                                    gotowka = int.Parse(Console.ReadLine());
                                    if (gotowka < 0 || gotowka > 1000000)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (gotowka == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (gotowka <= 0 || gotowka > 1000000);

                            telewizor.Policz(ilosc, ref gotowka);

                            Console.WriteLine("Zmodyfikowana gotowka przekazana przez referencje: {0}", gotowka);

                            Console.WriteLine("\n1.Cofnij");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);

                            wybor = 0;
                        }
                        else if (wybor == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile chcesz kupić telewizorów:\n");
                            do
                            {
                                try
                                {
                                    ilosc = int.Parse(Console.ReadLine());
                                    if (ilosc < 0 || ilosc > 100)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (ilosc == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (ilosc <= 0 || ilosc > 100);

                            Console.WriteLine("\nPodaj ile masz dostępnej gotówki.\n");
                            do
                            {
                                try
                                {
                                    gotowka = int.Parse(Console.ReadLine());
                                    if (gotowka < 0 || gotowka > 1000000)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (gotowka == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (gotowka <= 0 || gotowka > 1000000);

                            telewizor.Policz(out ilosc, gotowka);

                            Console.WriteLine("{0} - gotówka, {1} - ilosc.", gotowka, ilosc);

                            Console.WriteLine("\n1.Cofnij");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);

                            wybor = 0;
                        }

                    } while (wybor != 4);

                    wybor = 1;
                } 
                else if (wybor == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1. Argumenty przekazywane przez wartość.");
                        Console.WriteLine("2. Argumenty przekazywane przez referencję.");
                        Console.WriteLine("3. Argumenty przekazywane przez wyjście.");
                        Console.WriteLine("4. Cofnij.");

                        do
                        {
                            try
                            {
                                wybor = int.Parse(Console.ReadLine());
                                if (wybor < 1 || wybor > 4)
                                    Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                            }
                            catch
                            {
                                Console.WriteLine("\nBłędny znak!\n");
                            }
                        } while (wybor < 1 || wybor > 4);

                        if (wybor == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile chcesz kupić piekarników:");
                            Console.WriteLine();

                            do
                            {
                                try
                                {
                                    ilosc = int.Parse(Console.ReadLine());
                                    if (ilosc < 0 || ilosc > 100)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (ilosc == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (ilosc <= 0 || ilosc > 100);

                            Console.WriteLine("\nPodaj ile masz dostępnej gotówki.");
                            do
                            {
                                try
                                {
                                    gotowka = int.Parse(Console.ReadLine());
                                    if (gotowka < 0 || gotowka > 1000000)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (gotowka == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (gotowka <= 0 || gotowka > 1000000);

                            piekarnik.Policz(ilosc, gotowka);

                            Console.WriteLine("\n1.Cofnij");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);

                            wybor = 0;
                        }
                        else if (wybor == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile chcesz kupić piekarników:");
                            Console.WriteLine();

                            do
                            {
                                try
                                {
                                    ilosc = int.Parse(Console.ReadLine());
                                    if (ilosc < 0 || ilosc > 100)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (ilosc == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (ilosc <= 0 || ilosc > 100);

                            Console.WriteLine("\nPodaj ile masz dostępnej gotówki.");
                            do
                            {
                                try
                                {
                                    gotowka = int.Parse(Console.ReadLine());
                                    if (gotowka < 0 || gotowka > 1000000)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (gotowka == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("Błędny znak!\n");
                                }
                            } while (gotowka <= 0 || gotowka > 1000000);

                            piekarnik.Policz(ilosc, ref gotowka);

                            Console.WriteLine("Zmodyfikowana gotowka przekazana przez referencje: {0}", gotowka);

                            Console.WriteLine("\n1.Cofnij");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);

                            wybor = 0;
                        }
                        else if (wybor == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile chcesz kupić piekarników:");
                            Console.WriteLine();

                            do
                            {
                                try
                                {
                                    ilosc = int.Parse(Console.ReadLine());
                                    if (ilosc < 0 || ilosc > 100)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (ilosc == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (ilosc <= 0 || ilosc > 100);

                            Console.WriteLine("\nPodaj ile masz dostępnej gotówki.");
                            do
                            {
                                try
                                {
                                    gotowka = int.Parse(Console.ReadLine());
                                    if (gotowka < 0 || gotowka > 1000000)
                                        Console.WriteLine("\nWartość poza przedziałem! Podaj jeszcze raz.\n");
                                    if (gotowka == 0)
                                        Console.WriteLine("\nWartość nie moze być zerem! Podaj jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (gotowka <= 0 || gotowka > 1000000);

                            piekarnik.Policz(out ilosc, gotowka);

                            Console.WriteLine("\n1.Cofnij\n");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);

                            wybor = 0;
                        }
                    } while (wybor != 4);

                    wybor = 2;
                }
                else if (wybor == 3)
                {
                    Console.Clear();
                    Telewizor telewizor3 = new Telewizor(telewizor);
                    Telewizor telewizor4 = telewizor;

                    telewizor3.Wypisz();
                    telewizor4.Wypisz();

                    Console.WriteLine("");
                    Console.WriteLine("1. Cofnij.\n");
                    do
                    {
                        try
                        {
                            wybor = int.Parse(Console.ReadLine());
                            if (wybor != 1)
                                Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                        }
                        catch
                        {
                            Console.WriteLine("\nBłędny znak!\n");
                        }
                    } while (wybor != 1);

                    wybor = 3;
                }  
                else if (wybor == 4)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1. Telewizor.");
                        Console.WriteLine("2. Piekarnik.");
                        Console.WriteLine("3. Cofnij.\n");

                        do
                        {
                            try
                            {
                                wybor = int.Parse(Console.ReadLine());
                                if (wybor < 1 || wybor > 3)
                                    Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                            }
                            catch
                            {
                                Console.WriteLine("\nBłędny znak!\n");
                            }
                        } while (wybor < 1 || wybor > 3);

                        if (wybor == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile godzin telewizor jest włączony.");
                            double godzinyTel = 0;

                            do
                            {
                                try
                                {
                                    godzinyTel = double.Parse(Console.ReadLine());
                                    if (godzinyTel < 0 || godzinyTel > 24)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (godzinyTel < 0 || godzinyTel > 24);

                            Console.WriteLine("Podaj ile mocy ma twój telewizor.");
                            double mocTel = 0;

                            do
                            {
                                try
                                {
                                    mocTel = double.Parse(Console.ReadLine());
                                    if (mocTel < 0 || mocTel > 10000)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (mocTel < 0 || mocTel > 10000);

                            Telewizor t1 = new Telewizor();
                            t1.Moc = mocTel;
                            double kWh = Telewizor.ObliczKWH(t1.Moc, godzinyTel);

                            Console.WriteLine("\nZużywasz {0:F4} kWh w {1} godziny.", kWh, godzinyTel);

                            double cena = 0.60;
                            double wynik = kWh * cena;

                            Console.WriteLine("Zakładając, że 1 kWh wynosi {0:F2}gr, za 1 kWh zapłacisz: {1:F4}gr.", cena, wynik);

                            Console.WriteLine();
                            Telewizor tp2 = new Telewizor();
                            string model = Telewizor.Model = "LG";
                            Console.WriteLine("Model to: {0}", model);
                            Console.WriteLine("Czy moc pierwszego telewizora jest większa od drugiego?: {0}", t1 > tp2);
                            Telewizor t3 = new Telewizor();
                            t3 = t1 + tp2;
                            Console.WriteLine("Suma mocy dwóch telewizorów wynosi: {0}", t3.Moc);

                            Console.WriteLine();
                            Console.WriteLine("1.Cofnij.");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);
                        }
                        else if (wybor == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Podaj ile godzin piekarnik jest włączony.");
                            double godzinyPiek = 0;

                            do
                            {
                                try
                                {
                                    godzinyPiek = double.Parse(Console.ReadLine());
                                    if (godzinyPiek < 0 || godzinyPiek > 24)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (godzinyPiek < 0 || godzinyPiek > 24);

                            Console.WriteLine("Podaj ile mocy ma twój piekarnik.");
                            double mocPiek = 0;

                            do
                            {
                                try
                                {
                                    mocPiek = double.Parse(Console.ReadLine());
                                    if (mocPiek < 0 || mocPiek > 10000)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (mocPiek < 0 || mocPiek > 10000);

                            Piekarnik p1 = new Piekarnik(mocPiek);
                            double kWh = Piekarnik.ObliczKWH(p1.Moc, godzinyPiek);

                            Console.WriteLine("\nZużywasz {0:F4} kWh w {1} godziny.", kWh, godzinyPiek);

                            double cena = 0.60;
                            double wynik = kWh * cena;

                            Console.WriteLine("Zakładając, że 1 kWh wynosi {0:F2}gr, za 1 kWh zapłacisz: {1:F4}gr.", cena, wynik);

                            Console.WriteLine();
                            Piekarnik pp2 = new Piekarnik();
                            string model = Piekarnik.Model = "SAMSUNG";
                            Console.WriteLine("Model to: {0}", model);
                            Console.WriteLine("Czy moc pierwszego piekarnika jest większa od drugiego?: {0}", p1 > pp2);
                            Piekarnik p3 = new Piekarnik();
                            p3 = p1 + pp2;
                            Console.WriteLine("Suma mocy dwóch telewizorów wynosi: {0}", p3.Moc);

                            Console.WriteLine();
                            Console.WriteLine("1.Cofnij.");

                            do
                            {
                                try
                                {
                                    wybor = int.Parse(Console.ReadLine());
                                    if (wybor != 1)
                                        Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                                }
                                catch
                                {
                                    Console.WriteLine("\nBłędny znak!\n");
                                }
                            } while (wybor != 1);
                        }
                        
                    } while (wybor != 3);                   

                    wybor = 4;
                }
                else if (wybor == 5)
                {
                    Console.Clear();
                    //Zespolone.Menu();

                    double lre, lim, mnoznik;
                    Console.WriteLine("Podaj część rzeczywistą trzeciej liczby zespolonej: ");
                    lre = double.Parse(Console.ReadLine().ToString());
                    Console.WriteLine("Podaj część urojoną trzeciej liczby zespolonej: ");
                    lim = double.Parse(Console.ReadLine().ToString());
                    Console.WriteLine("Podaj wartość mnożnika: ");
                    mnoznik = double.Parse(Console.ReadLine().ToString());

                    //Wywołanie metody niestatycznej
                    Zespolone LiczbaZesp = new Zespolone(lre, lim);
                    Zespolone Wynik = new Zespolone();
                    LiczbaZesp.mnoznik = mnoznik;
                    Wynik = LiczbaZesp.IloczynLiczZesp(LiczbaZesp);
                    Console.WriteLine("Iloczyn {0:F4} + j {1:F4} przez {2:F4} wynosi {3:F4} + j {4:F4}.", lre, lim, mnoznik, Wynik.RePart, Wynik.ImPart);

                    //Wywołanie metody statycznej
                    Wynik = Zespolone.IloczynLiczbaZesp(LiczbaZesp, mnoznik);
                    Console.WriteLine("Iloczyn {0:F4} + j {1:F4} przez {2:F4} wynosi {3:F4} + j {4:F4}.", lre, lim, mnoznik, Wynik.RePart, Wynik.ImPart);

                    //Wyświetlanie modułu i kąta
                    Console.WriteLine("Wartość modułu wynosi {0:F4}.", Wynik.Modul);
                    Console.WriteLine("Wartość kąta wynosi {0:F4} deg.", Wynik.Kat * 180 / Math.PI);

                    //Zmodyfikuj wartość zmiennej LiczbaZesp
                    Console.WriteLine("Podaj nową wartość części rzeczywistej: ");
                    Wynik.RePart = double.Parse(Console.ReadLine().ToString());
                    Console.WriteLine("Podaj nową wartość części urojonej: ");
                    Wynik.ImPart = double.Parse(Console.ReadLine().ToString());
                    Console.WriteLine("Wartość modułu wynosi {0:F4}.", Wynik.Modul);
                    Console.WriteLine("Wartość kąta wynosi {0:F4} deg.", Wynik.Kat * 180 / Math.PI);

                    Console.WriteLine("");
                    Console.WriteLine("1. Cofnij.");
                    do
                    {
                        try
                        {
                            wybor = int.Parse(Console.ReadLine());
                            if (wybor != 1)
                                Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                        }
                        catch
                        {
                            Console.WriteLine("\nBłędny znak!\n");
                        }
                    } while (wybor != 1);
                }
            } while (wybor != 6);
        }
    }
}
