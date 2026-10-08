using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MusaS_5AD
{
    internal class Program
    {
        private static string naam;

        static void Main(string[] args)
        {
            /* Musa Shakhidov
             * 22/09/2026
             * Oefening 4
             */

            // Velden
            string _programmeur = null;
            string _naam = null;
            string _bewerking = null;

            // Programma

            // Stap 1: Vraag naam + opslaan
            Console.WriteLine("Wat is u naam?");
            _naam = Console.ReadLine();
            Console.Clear();
            _programmeur = "Musas";
            // Stap 2: Maak de juiste tekst.
            Console.WriteLine("Hallo, " + _naam );
            Console.WriteLine("Mijn naam is " + _programmeur + " en ik ben de programmeur.");
            // Stap 3: Toon de tekst in de juiste vorm.
            Console.ReadKey();

        }
    }
}
