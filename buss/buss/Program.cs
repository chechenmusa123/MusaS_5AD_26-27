using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe oud ben je?");
                int leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jij bent " + leeftijd + " jaar oud.");
            Console.Read();
        }
    }
}
