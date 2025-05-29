using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nombre))
        {
            char inicial = char.ToUpper(nombre[0]);

            Console.WriteLine($"\nLa inicial de tu nombre es: {inicial}");
        }
        else
        {
            Console.WriteLine("No ingresaste un nombre válido.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}