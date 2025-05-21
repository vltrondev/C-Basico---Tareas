using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Calculador
    {
        public void Calculadora()
        {
            bool button = true;
            string[] lista = new string[6] { "1. Suma", "2. Resta", "3. Multiplicación", "4. División", "5. potencia", "6. Salir" };
            
            while (button)
            {
                // Listar elementos siempre que termine una operacion
                foreach (string i in lista) {Console.WriteLine($"\n{i}");}

                // Seleccion de elementos
                Console.Write("Elije el numero de la opcion que desees: ");
                var option = Console.ReadLine();

                if (option == "6")
                {
                    Console.WriteLine("Gracias por usar la calculadora");
                    button = false;
                    continue;
                }

                // Insertacion de numeros
                Console.Write("number 1: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("number 2: ");
                int num2 = int.Parse(Console.ReadLine());
                
                // operaciones por casos
                switch (option)
                {
                    case "1":
                        Console.WriteLine($"result: {num1 + num2}");
                        break;
                    case "2":
                        Console.WriteLine($"result: {num1 - num2}");
                        break;
                    case "3":
                        Console.WriteLine($"result: {num1 * num2}");
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine(num1 / num2);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine($"Error al dividir por 0");
                        }

                        break;
                    case "5":
                        Console.WriteLine(Math.Pow(num1, num2));
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }
            }

        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculador calculador = new Calculador();
            calculador.Calculadora();


        }
    }
}
