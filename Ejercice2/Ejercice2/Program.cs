using System;



namespace Ejercice2
{ 
    public class Ejercice2
    {
        public void Ejercice()
        {
            Console.Write("Ingrese numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado: {numero * numero2}");
        
        
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Ejercice2 ejercice = new Ejercice2();
            ejercice.Ejercice();

        }
    
    
    }



}