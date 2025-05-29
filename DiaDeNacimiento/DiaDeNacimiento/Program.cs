using System;
class DiaDeNacimiento
{
    static void Main()
    {
        MostrarEncabezado();

        DateTime fechaNacimiento = ObtenerFechaValida();

        MostrarResultado(fechaNacimiento);

        FinalizarPrograma();
    }

    static void MostrarEncabezado()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("  DESCUBRE TU DÍA DE NACIMIENTO");
        Console.WriteLine("====================================");
        Console.WriteLine("\nPor favor, ingresa tu fecha de nacimiento.\n");
    }

    static DateTime ObtenerFechaValida()
    {
        DateTime fecha;
        while (true)
        {
            Console.Write("Formato: (dd/mm/aaaa) o (mm/dd/aaaa): ");
            string entrada = Console.ReadLine();

            if (DateTime.TryParse(entrada, out fecha))
            {
                if (fecha > DateTime.Today)
                {
                    Console.WriteLine("¡No puedes haber nacido en el futuro! Intenta nuevamente.");
                }
                else
                {
                    return fecha;
                }
            }
            else
            {
                Console.WriteLine("Formato no válido. Por favor usa el formato indicado.");
            }
        }
    }

    static string ObtenerNombreDia(DayOfWeek dia)
    {
        return dia switch
        {
            DayOfWeek.Sunday => "Domingo",
            DayOfWeek.Monday => "Lunes",
            DayOfWeek.Tuesday => "Martes",
            DayOfWeek.Wednesday => "Miércoles",
            DayOfWeek.Thursday => "Jueves",
            DayOfWeek.Friday => "Viernes",
            DayOfWeek.Saturday => "Sábado",
        };
    }

    static void MostrarResultado(DateTime fecha)
    {
        string nombreDia = ObtenerNombreDia(fecha.DayOfWeek);
        string fechaFormateada = fecha.ToString("dddd, dd 'de' MMMM 'de' yyyy",
                                      new System.Globalization.CultureInfo("es-ES"));

        Console.WriteLine("\n------------------------------------");
        Console.WriteLine($"  ¡Naciste un {nombreDia.ToUpper()}!");
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"  Fecha: {fechaFormateada}");
        Console.WriteLine($"  Edad aproximada: {CalcularEdad(fecha)} años");
        Console.WriteLine("------------------------------------\n");
    }

    static int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - fechaNacimiento.Year;

        if (hoy.Month < fechaNacimiento.Month ||
           (hoy.Month == fechaNacimiento.Month && hoy.Day < fechaNacimiento.Day))
        {
            edad--;
        }

        return edad;
    }

    static void FinalizarPrograma()
    {
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
