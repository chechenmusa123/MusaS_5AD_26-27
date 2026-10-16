using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_MusaS_5AD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Musa Shakhidov
             * Oefening 
             * 13/10/2026
             */

            // Velden

            //Velden
            float _floatvar = 0f;
            Double _doublevar = 0;
            Decimal _decimalvar = 0m;

            //Programma
            //Stap 1: Bereken 0.1 + 0.2 in de 3 typen van variabelen
            _floatvar = 0.1f + 0.2f;
            _doublevar = 0.1 + 0.2;
            _decimalvar = 0.1M + 0.2M;


            //Stap 2: Toon de resultaten
            Console.WriteLine($"float: {_floatvar}");
            Console.WriteLine($"float: {_doublevar}");
            Console.WriteLine($"float: {_decimalvar}");
            //Stap 3: ga na of float exact 0.3 weergeeft
            if (_floatvar == 0.3)
            {
                // Als ja: 
                //           Stap4: Toon exact 0.3
                Console.WriteLine("exact 0.3");
            }
            //Als nee: 
            else
            {     //            Stap5: Toon niet 0.3
                Console.WriteLine("Niet 0.3");
            }


            //Stap 6: ga na of float exact 0.3 weergeeft
            if (_doublevar == 0.3)
            {
                // Als ja: 
                //           Stap7: Toon exact 0.3
                Console.WriteLine("exact 0.3");
            }
            //Als nee: 
            else
            {     //            Stap8: Toon niet 0.3
                Console.WriteLine("Niet 0.3");
            }


            //Stap 9: ga na of float exact 0.3 weergeeft
            if (_decimalvar == 0.3m)
            {
                // Als ja: 
                // Stap10: Toon exact 0.3
                Console.WriteLine("exact 0.3");
            }
            //Als nee: 
            else
            {     //Stap11: Toon niet 0.3
                Console.WriteLine("Niet 0.3");
            }
        }
    }
}
