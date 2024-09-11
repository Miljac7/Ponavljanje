using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niz_znakova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upisite recenicu: ");
            string input = Console.ReadLine();

            string output = input.Replace(" ", "_");
            Console.WriteLine("kraj:" + output);
            Console.ReadLine();
        }
    }
}
