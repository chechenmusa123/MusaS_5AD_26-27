using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Musa Shakhidov
             * Oefening 26
             * 15/10/2026
             */

            // Velden

            Byte _Keuze_Gebruiker = 0;

            // Programma
            do
            {
                try
                {
                    //Stap 1: geef de gebruiker zijn 3 keuzes en slaag zijn keuze op
                    Console.WriteLine("maak uw keuze uit ondesrtaand menu.\n “keuze 1”, “keuze 2”, “keuze 3” “keuze 4: afsluiten” ");
                _Keuze_Gebruiker = Byte.Parse(Console.ReadLine());
               
                    // Stap 2: Toon de gebruiker zijn keuze en zorg ervoor dat het keuze menu terug op scherm komt

                   // Console.WriteLine($"\nUw keuze: {_Keuze_Gebruiker.ToString()}");
                    
                   // Console.ReadKey();

                    // als 1
                    if (_Keuze_Gebruiker == 1)
                    {
                        Console.WriteLine("U gaf keuze 1 in.\n");
                    }
                    // als 2
                    else if (_Keuze_Gebruiker == 2)
                    {
                        Console.WriteLine("U gaf keuze 2 in.\n");
                    }
                    // als 3
                    else if (_Keuze_Gebruiker == 3)
                    {
                        Console.WriteLine("U gaf keuze 3 in.\n");
                    }
                    // als 4
                    else if (_Keuze_Gebruiker == 4)
                    {
                        Console.WriteLine("U gaf keuze 4 in. see you later nigga!\n");
                    }
                    else
                        Console.WriteLine("Niet good\n");
                }
                catch
                {
                    // scherm wissen
                    Console.Clear();
                    // Foutmelding
                    Console.Write("U gaf geen getal in!");
                    Console.Write("\nDruk op enter om naar het keuzemenu te gaan.");
                }

            } while (_Keuze_Gebruiker != 4);

        }
    }
}
