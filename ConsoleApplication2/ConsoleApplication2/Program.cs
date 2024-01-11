using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static string Imenik(string korisnik)
        {
          
           
            
            
            
            
            
            switch( korisnik)

        { case "d":
                     int[] niz1 = { 0, 5, 6, 3, 2, 1, 7, 8, 9, 10,1, };
            int clan1= niz1.Length;
            for (int i = 0; i < clan1; i++)
            {
                Console.Write(niz1[i]);
                if (i < clan1 - 1)
                    Console.Write("");
                else
                    Console.Write("\n");
            }
            break;
                case "p":
                     int[] niz2 = { 0, 4, 6, 4, 2, 1, 2, 8, 9, 10,1, };
            int clan2 = niz2.Length;
            for (int i = 0; i < clan2; i++)
            {
                Console.Write(niz2[i]);
                if (i < clan2 - 1)
                    Console.Write("");
                else
                    Console.Write("\n");
            }
                    break;
                case "m":
                     int[] niz = { 0, 9, 6, 3, 11, 1, 7, 4, 9, 18,1, };
            int clan = niz.Length;
            for (int i = 0; i < clan; i++)
            {
                Console.Write(niz[i]);
                if (i < clan - 1)
                    Console.Write("");
                else
                    Console.Write("\n");
            }
            break;
               
                default:
            Console.WriteLine("Pogresan izbor");
            break;

        }
            return korisnik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Odaberite korisnika kojeg zelite da pozovete");
            Console.WriteLine("Odaberite d za korisnika 'Dragan Jovanovic' ");
            Console.WriteLine("Odaberite p za korsnika  'Petar Petrovic' ");
            Console.WriteLine("Odaberite m za korsnika 'Marko Maksimovic' ");
            try
            {

                for (int br = 1; br <= 3; )
                {
                    string korisnik = "";
                    korisnik = Console.ReadLine().ToLower();
                    string korisnik1 = Imenik(korisnik);
                    br++;

                }
            }
            catch
            {
                Console.WriteLine("Pogresan unos");
            }
             Console.ReadKey();


        }
    }
}
