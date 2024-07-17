using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad_07
{
    class Zad
    {
        static void Main(string[] args)
        {
            Motocykl motocykl = new Motocykl();
            Tramwaj tramwaj = new Tramwaj();
            Zdarzenia wypadek = new Zdarzenia();

            int wybor = -1;
            int znak = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Kto miał wypadek?");
                Console.WriteLine("1. Motocykl.");
                Console.WriteLine("2. Tramwaj.");
                Console.WriteLine("3. Wyjdź.");
                Console.WriteLine();

                do
                {
                    try
                    {
                        wybor = int.Parse(Console.ReadLine());
                        if (wybor < 1 || wybor > 3)
                            Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n{0}\n", e.Message);
                    }
                } while (wybor < 1 || wybor > 3);
                
                if (wybor == 1)
                {
                    wybor = -1;
                    Console.Clear();

                    Console.WriteLine("Czy było to coś poważnego?");
                    Console.WriteLine("1 - tak, 0 - nie.\n");

                    do
                    {
                        try
                        {
                            znak = int.Parse(Console.ReadLine());
                            if (znak < 0 || znak > 1)
                                Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n{0}\n", e.Message);
                        }
                    } while (znak < 0 || znak > 1);

                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("\n");

                    if (znak == 1)
                    {
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(tramwaj.Reakcja);
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(motocykl.Akcja);
                    }
                    else if (znak == 0)
                    {
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(tramwaj.Reakcja);
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(motocykl.Akcja);
                    }

                    wypadek.OgloszenieWypadku(znak);

                    wypadek.AnulujSubskrypcje(2);

                    Console.WriteLine("\n1. Cofnij.\n");

                    do
                    {
                        try
                        {
                            wybor = int.Parse(Console.ReadLine());
                            if (wybor != 1)
                                Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n{0}\n", e.Message);
                        }
                    } while (wybor != 1);
                }
                else if (wybor == 2)
                {
                    wybor = -1;
                    Console.Clear();

                    Console.WriteLine("Czy to było coś poważnego?");
                    Console.WriteLine("1 - tak, 0 - nie.\n");

                    do
                    {
                        try
                        {
                            znak = int.Parse(Console.ReadLine());
                            if (znak < 0 || znak > 1)
                                Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n{0}\n", e.Message);
                        }
                    } while (znak < 0 || znak > 1);

                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("\n");

                    if (znak == 1)
                    {
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(motocykl.Reakcja);
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(tramwaj.Akcja);
                    }
                    else if (znak == 0)
                    {
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(motocykl.Reakcja);
                        wypadek.OglosWypadek += new Zdarzenia.Wypadek(tramwaj.Akcja);
                    }

                    wypadek.OgloszenieWypadku(znak);

                    wypadek.AnulujSubskrypcje(2);

                    Console.WriteLine("\n1. Cofnij.\n");

                    do
                    {
                        try
                        {
                            wybor = int.Parse(Console.ReadLine());
                            if (wybor != 1)
                                Console.WriteLine("\nLiczba nie zgadza się z zakresem. Wybierz jeszcze raz.\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n{0}\n", e.Message);
                        }
                    } while (wybor != 1);
                }
            } while (wybor != 3);
        }
    }
}