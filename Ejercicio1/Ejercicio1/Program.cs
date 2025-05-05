using System;
using System.Collections.Generic;

namespace Ejercice
{
    public class Ejercice
    {
        public void Ejercice1(int number1, int number2)
        {

            try
            {
                Console.WriteLine(number1 / number2);

            }

            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dividir: {e.Message}");
            }


        }


    }

    class Program 
    {
        static void Main(string[] args)
        {
            Ejercice ejercice = new Ejercice();
            ejercice.Ejercice1(10, 0);


        }


    }


}