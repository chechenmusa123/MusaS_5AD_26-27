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
             * Musa Shakhidov
             * Oefening 16
             * 13/10/2026
             */

            // Velden

            int Keuze_Gebruiker = 0;


            // Programma

            try
            { 
                //Stap 1: Geef de gebruiker keuzes tussen 3 kleuren.
                Console.Write("Kies een kleur (geef het getal in van uw gewenste optie):\n1. rood,\n2. groen\n3. blauw.");

                //Stap 2: Slaag gebruiker zijn keuze op.
                Keuze_Gebruiker = int.Parse(Console.ReadLine());

                //Stap 3: Scherm leeg maken
                Console.Clear();

                //Stap 4: Toon de juiste tekst
                if (Keuze_Gebruiker == 1)
                {
                    Console.Write("je koos de volgende kleur: rood");
                }
                else if (Keuze_Gebruiker == 2)
                {
                    Console.Write("je koos de volgende kleur: groen");
                }
                else if (Keuze_Gebruiker == 3)
                {
                    Console.Write("je koos de volgende kleur: blauw");
                }
                else
                    Console.Write("Je gaf geen geldige keuze in!");
            }
            catch
            { Console.Write("Heb je wel een getal ingegeven?"); }
        }
    }
}
