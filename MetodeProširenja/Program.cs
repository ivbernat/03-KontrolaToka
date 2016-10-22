using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sadrži:");
            string[] riječi = new string[] { "Franjo", "Ivana", "Dora", "Mirko" };
            Console.WriteLine(Pretraga.Sadrži(riječi, "Ivana"));

            Console.WriteLine("Zbroj:");
            int[] brojevi = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(Pretraga.Zbroj(brojevi));

            Console.WriteLine("NađiSveIza:");
            riječi = new string[] { "more", "sunce", "rijeka", "mjesec", "potok", "barka" };
            foreach (string riječ in Pretraga.NađiSveIza(riječi, "student"))
                Console.WriteLine(riječ);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
