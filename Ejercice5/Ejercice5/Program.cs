using System;


namespace Program
{
    public class PrimoChecker
    {
        public static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var limite = (int)Math.Sqrt(numero);

            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        public class Program
        { 
            static void Main(string[] args)
            {
                int numero = 6;
                if (PrimoChecker.EsPrimo(numero))
                {
                    Console.WriteLine($"{numero} es un número primo");
                }
                else
                {
                    Console.WriteLine($"{numero} no es un número primo");
                }

            }
        
        }
    }

}