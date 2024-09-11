using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite URL adresu: ");
            string url = Console.ReadLine();

            if (IsValidUrl(url))
            {
                Console.WriteLine("URL adresa je ispravna.");
            }
            else
            {
                Console.WriteLine("URL adresa nije ispravna.");
            }
        }

        static bool IsValidUrl(string url)
        {
            if (url.StartsWith("www") && url.EndsWith("hr"))
            {
                string[] parts = url.Split('.');
                if (parts.Length > 2 && parts[1] != "")
                {
                    return true;
                }
            }
        }
    }
}
