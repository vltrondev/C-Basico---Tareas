using System;
using System.Globalization;

class Program
{
    static void Main()
    {

        DateTime fechaActual = DateTime.Now;
        CultureInfo cultura = new CultureInfo("es-ES");


        int año = fechaActual.Year;
        int mes = fechaActual.Month;
        string nombreMes = cultura.DateTimeFormat.GetMonthName(mes);

        Console.WriteLine($"\n {char.ToUpper(nombreMes[0])}{nombreMes.Substring(1)} {año}\n");
        Console.WriteLine("lu ma mi ju vi sá do");
        Console.WriteLine("--------------------");

        DateTime primerDiaMes = new DateTime(año, mes, 1);
        DayOfWeek diaSemanaInicio = primerDiaMes.DayOfWeek;

        int inicio = ((int)diaSemanaInicio + 6) % 7;
        if (inicio == 6) inicio = -1; 

        int diasEnMes = DateTime.DaysInMonth(año, mes);

        int diaActual = 1;

        for (int i = 0; i < inicio; i++)
        {
            Console.Write("   ");
        }

        while (diaActual <= diasEnMes)
        {
            for (int i = inicio; i < 7 && diaActual <= diasEnMes; i++)
            {
                Console.Write($"{diaActual,2} ");
                diaActual++;
                inicio = 0; 
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}