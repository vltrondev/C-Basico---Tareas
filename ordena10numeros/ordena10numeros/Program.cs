using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordena10numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int[] numbers = new int[10];

            while (number < 10)
            {
                Console.Write($"NUMBERO{number + 1}: ");
                int num = int.Parse(Console.ReadLine());
                numbers[number] = num;
                number++;
                
            }
            Array.Sort(numbers);
            Console.WriteLine("\nLista ordenada!");

            foreach (int i in numbers)
            { 
                Console.WriteLine(i);
            }


        }
    }
}
