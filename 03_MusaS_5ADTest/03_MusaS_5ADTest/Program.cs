using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MusaS_5ADTest
{
    internal class Program
    {
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
            _programmeur = "Musa";
            // Stap 2: Maak de juiste tekst.
            _bewerking = $"Hallo, {_naam} \nMijn naam is {_programmeur} en ik ben de programmeur.";
            Console.WriteLine(_bewerking);
            Console.ReadKey();
            // Stap 3: Toon de tekst in de juiste vorm.
            
        }
    }
}
