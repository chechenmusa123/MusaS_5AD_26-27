using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Musa Shakhidov
             * Oefening 14
             * 08/10/2026
             */
            // Velden

            int _getal1 = 0;
            int _getal2 = 0;

            int _bewerking1 = 0;
            int _bewerking2 = 0;
            int _bewerking3 = 0;
            int _bewerking4 = 0;

            //Programma

            //Stap 1: Vraag getal 1 + opslaan

            try
            {
                Console.WriteLine("Geef mij een natuurlijke getal.");

                _getal1 = int.Parse(Console.ReadLine());

                //Stap 2: Vraag getal 2 + opslaan
                Console.WriteLine("Geef mij een tweede natuurlijke getal.");
                try
                {
                    _getal2 = int.Parse(Console.ReadLine());

                    //Stap 3: som van getal 1 en getal 2 + opslaan 

                    _bewerking1 = _getal1 + _getal2;

                    //Stap 4: Het juiste tekst opmaken
                    Console.WriteLine($"Het som van de twee getallen is {_bewerking1.ToString()}");

                    Console.ReadKey();
                    Console.Clear();

                    //Stap 5: Het som vermenigvuldigen met 5 + opslaan

                    _bewerking2 = _bewerking1 + 5;

                    //Stap 6: Het juiste tekst opmaken
                    Console.WriteLine($"Nu hebben we plus 5 toegevoegd. {_bewerking2.ToString()}");

                    Console.ReadKey();
                    Console.Clear();

                    //Stap 7: Het som vermenigvuldigd met 5 nog eens vermenigvuldigen met 10 + opslaan

                    _bewerking3 = _bewerking2 * 10;

                    //Stap 8: Het juiste tekst opmaken
                    Console.WriteLine($"het vorig getal vermenigvuldigd met 10 is {_bewerking3.ToString()}");

                    Console.ReadKey();
                    Console.Clear();

                    //Stap 9: Het som vermenigvuldigd met 5 nog eens vermenigvuldigen met 10 nu delen met 2 + opslaan

                    _bewerking4 = _bewerking3 / 2;

                    Console.WriteLine($"Nu delen we de vorig getal met 2 en dat is {_bewerking4.ToString()}");

                    Console.ReadKey();
                    Console.Clear();

                }
                catch
                {
                    Console.Clear();

                    Console.WriteLine("Ben je zeker dat je tweede getal een natuurlijke getal is? Probeer opnieuw.");

                    Console.ReadKey();
                }
            }
            catch
            {
                Console.Clear();

                Console.WriteLine("Ben je zeker dat je eerste getal een natuurlijke getal is? Probeer opnieuw.");

                Console.ReadKey();
            }

        }
      
    }
}
