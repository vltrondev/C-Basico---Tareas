using System;


namespace Program
{
    public class Ejercice3
    { 
        public void ejercice()
        {
            for (int i = 0; i < 30; i++)
            { 
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Numero impar: {i}");

                }

            }
        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ejercice3 oEjercice = new Ejercice3();
            oEjercice.ejercice();
        
        }

    }


}