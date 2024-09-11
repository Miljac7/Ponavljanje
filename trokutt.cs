using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Provjera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z)
                {
                    Console.WriteLine("Vrijednosti su stranice pravokutnog trokuta.");
                }
                else
                {
                    Console.WriteLine("Vrijednosti nisu stranice pravokutnog trokuta.");
                }
            }
            else
            {
                Console.WriteLine("Vrijednosti moraju biti veće od 0.");
            }

            Console.ReadLine();
        }
    }
}
