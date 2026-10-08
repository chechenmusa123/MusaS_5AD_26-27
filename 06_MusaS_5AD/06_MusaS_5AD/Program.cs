using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Musa Shakhidov
             * Oefening 6
             * 29/09/2026
             */

            //Velden
            string _kleur = null;
            string _dag = null;
            string _seizoen = null;

            //Programma

            //Stap 1: Vraag naam + opslaan

            Console.WriteLine("Kies een kleur");
            _kleur = Console.ReadLine();

            //Stap 2: Bewerking, Maak de juiste tekst.

            Console.WriteLine("\nJe koos " + _kleur);
            Console.WriteLine("\nDruk op enter om verder te gaan");
            //Stap 3: Toon de tekst in de juiste vorm.

            Console.ReadKey();
            Console.Clear();

            //Stap 4: Vraag dag +opslaan

            Console.WriteLine("Geef je favoriete week dag");
            _dag = Console.ReadLine();

            //Stap 5: Bewerking, Maak de juiste tekst.

            Console.WriteLine("\nJe favoriete dag is " + _dag);
            Console.WriteLine("\nDruk op enter om verder te gaan");
            //Stap 6: Toon de tekst in de juiste vorm.

            Console.ReadKey();
            Console.Clear();

            //Stap 7: Vraag seizoen +opslaan

            Console.WriteLine("Geef je favoriete seizoen");
            _seizoen = Console.ReadLine();

            //Stap 8: Bewerking, Maak de juiste tekst.

            Console.WriteLine("\nJe favoriete seizoen is " + _seizoen);
            Console.WriteLine("\nDruk op enter om verder te gaan");

            //Stap 9: Toon de tekst in de juiste vorm.

            Console.ReadKey();
            Console.Clear();

        }
    }
}
