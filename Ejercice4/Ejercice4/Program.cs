using System;

namespace Program
{ 
    public class Ejercice
    {
        public void ejercice()
        {
            Console.Write("Ingrese el coeficiente a: ");
            double variable = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el coeficiente b: ");
            double svariable = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el coeficiente de c: ");
            double tvariable = double.Parse(Console.ReadLine());
            double discriminante = variable * variable - 4 * svariable * tvariable;
            Console.WriteLine($"Solucion: {discriminante}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Ejercice oEjercice = new Ejercice();
            oEjercice.ejercice();
        
        }
    
    }


}