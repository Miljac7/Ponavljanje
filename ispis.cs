using System;

class Program
{
    static void Main()
    {
        int[] niz = { 5, 2, 8, 1, 4 };

        Array.Sort(niz);

        Console.WriteLine("Sortirani niz:");
        foreach (int broj in niz)
        {
            Console.WriteLine(broj);
        }
    }
}
