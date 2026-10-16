using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Musa Shakhidov
             * Oefening 27
             * 16/10/2026
             */

            // Velden

            string _Keuze1 = "Hallo Wereld";
            string _Keuze2 = "Hallo,";
            string _NaamGebruiker = null;
            int _KeuzeGebruiker = 0;

            // Programma
            do
            {
                try
                {
                    //Stap 1: geef het gebruiker een tekst dat keuze weergeeft
                    Console.WriteLine("Keuze 1: Hallo Wereld\nKeuze 2: Hallo, <uw naam>.\nKeuze 3: Sluit het af.\n");
                    _KeuzeGebruiker = int.Parse(Console.ReadLine());
                    //Stap 2: indien hij een tekst gewoon wilt toon jij het 
                    if (_KeuzeGebruiker == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"{_Keuze1}");
                    }
                    //Stap 3: indien hij het tekst met zijn naam wilt toon jij het
                    else if (_KeuzeGebruiker == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("sinds dat jij keuze 2 hebt ingedient, geef uw naam in");
                        _NaamGebruiker = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"{_Keuze2} {_NaamGebruiker}");

                    }
                    else if (_KeuzeGebruiker == 3)
                    {
                        Console.Clear();
                        Console.Write("Wij sluiten het voor u.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("U gaf geen geldige nummer in!");
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("U gaf geen GETAL in!");
                }
            }
            while (_KeuzeGebruiker != 3);
        }
    }
}
