using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosjek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 7;
            double c = 12.5;
            double d = 16.7;

            double suma = a + b + c + d;
            double prosijek = suma / 4;

            Console.WriteLine( "Prosjecna vrijednost je: " + prosijek);
            Console.ReadLine();
        }
    }
}