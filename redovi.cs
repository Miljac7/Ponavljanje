using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("Unesite broj članova reda: ");
        n = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += 1.0 / i;
        }

        Console.WriteLine($"Suma reda za {n} članova je: {suma}");
    }
}
