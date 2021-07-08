using System;

namespace cshello
{
    class Program
    {
        
     
            static void Main(string[] args)
            {
                Console.WriteLine("i am \talive\n");
                Console.WriteLine("hello \nuser..");

                int pocetStromov = 15;
                double vyskaKlienta = 1.85;
                string menoKlienta = "Peter Sagan";

                Console.WriteLine("Pocet stromov je: " + pocetStromov);
                Console.WriteLine("Vyska zamestnanca je: " + vyskaKlienta);
                Console.WriteLine("Meno klienta je: " + menoKlienta);

                int a = 5;
                double b = 2.0;
                double vysledok;

                vysledok = a / b;
                Console.WriteLine("Vysledok je: " + vysledok);
                Console.ReadLine();

            }
        }
    }

