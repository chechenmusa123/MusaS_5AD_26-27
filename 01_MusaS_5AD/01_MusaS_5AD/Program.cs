using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Musa shakhidov
             * Oefening 10
             * 01/10/2026
             */

            // Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _getal3 = 0;
            // Programma
            try
            {
                //Stap 1: Vraag getal 1 + opslaan
                Console.Write("Geef mij een random 1ste getal. ");
                //Stap 2: omvormen naar integral
                _getal1 = int.Parse(Console.ReadLine());

                //Stap 3: Vraag getal 2 + opslaan
                Console.Write("Geef mij een random 1ste getal. ");
                //Stap 4: omvormen naar integral
                _getal2 = int.Parse(Console.ReadLine());

                //Stap 5: Vraag getal 3 + opslaan
                Console.Write("Geef mij een random 1ste getal. ");
                //Stap 6: omvormen naar integral
                _getal3 = int.Parse(Console.ReadLine());


                // Overige tekst verwijderen.
                Console.Clear();

                //Stap 7: Toon de juiste tekst.
                Console.WriteLine($"3de getal: + { _getal3.ToString()}");
                Console.WriteLine("2de getal: " + _getal2);
                Console.WriteLine("1ste getal: " + _getal1);
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.Write("oops something went wrong.");
                Console.ReadKey();
            }
        }
    }
}
