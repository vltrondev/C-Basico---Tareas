using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Serie Fibonacci hasta 50:");

        int a = 0, b = 1, c = 0;

        // Imprimir los dos primeros números (1)
        Console.Write("1 ");

        while (b <= 50)
        {
            Console.Write(b + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}