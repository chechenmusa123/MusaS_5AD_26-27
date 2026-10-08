using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Musa Shakhidov
             * Oefening 9
             * 01/10/2026
             */
            // Velden
            int _getal = 0;

            // Programma
            try { 
            //Stap 1: Vraag getal aan gebruiker + opslaan
            Console.Write("Geef een random natuurlijk getal. :D ");
            _getal = int.Parse(Console.ReadLine());

                // scherm leegmaken
                Console.Clear();

                // Stap 2: Toon de tekst
                Console.WriteLine($"U gaf het volgende getal in: {_getal.ToString()}");
            }
            catch
            {
                // scherm leegmaken
                Console.Clear();

                //Stap 2: Toon de tekst of de foutmelding
                Console.WriteLine("Er ging iets fout.");
            }


        }
    }
}
