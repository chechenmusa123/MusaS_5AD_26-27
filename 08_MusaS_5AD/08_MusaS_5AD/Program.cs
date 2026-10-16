using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Musa Shakhidov
             * Oefening 15
             * 09/10/2026
             */

            // Velden

            int _getal = 0;
            const int _vergelijk = 100;

            // Programma

            //Stap 1: vraag gebruiker of dat hij een positieve getal wilt ingeven dat geen 100 is.

            try
            {
                Console.Write("Geef een positieve getal in dat NIET 100 is.\n");
                _getal = int.Parse(Console.ReadLine());

                if (_getal < _vergelijk)
                {
                    Console.Clear();
                    Console.Write("Het getal is kleiner dan 100. ");
                }
                else if (_getal > _vergelijk)
                {
                    Console.Clear();
                    Console.Write("Het getal is groter dan 100.");
                }
                else
                {
                    Console.Clear();
                    Console.Write("Heb je het getal 100 ingegeven? Als ja dat mag niet!");
                }
            }
            catch
            {
                Console.Write("Heb je de regel goed gevolgd?");
            }
        }
    }
}