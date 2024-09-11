using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Fibonaccijev član na poziciji {n} je: {Fibonacci(n)}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

