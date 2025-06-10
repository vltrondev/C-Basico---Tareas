using System;
using System.Collections.Generic;

class Program
{
    static List<Cliente> clientes = new List<Cliente>();

    class Cliente
    {
        public string Nombre;
        public int Edad;
        public string Telefono;
        public string Membresia;
    }

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n*** Registro de clientes del Gimnasio ***");
            Console.WriteLine("1. Dar de alta un cliente");
            Console.WriteLine("2. Mostrar detalles de un cliente");
            Console.WriteLine("3. Listar clientes");
            Console.WriteLine("4. Buscar cliente (Nombre)");
            Console.WriteLine("5. Dar de baja un cliente");
            Console.WriteLine("6. Modificar un cliente");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AltaCliente();
                    break;
                case 2:
                    MostrarCliente();
                    break;
                case 3:
                    ListarClientes();
                    break;
                case 4:
                    BuscarCliente();
                    break;
                case 5:
                    BajaCliente();
                    break;
                case 6:
                    ModificarCliente();
                    break;
                case 7:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 7);
    }

    static void AltaCliente()
    {
        Console.WriteLine("\n--- Alta de cliente ---");
        Cliente nuevo = new Cliente();

        Console.Write("Nombre: ");
        nuevo.Nombre = Console.ReadLine();

        Console.Write("Edad: ");
        nuevo.Edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Teléfono: ");
        nuevo.Telefono = Console.ReadLine();

        Console.Write("Tipo de membresía: ");
        nuevo.Membresia = Console.ReadLine();

        clientes.Add(nuevo);
        Console.WriteLine("Cliente registrado con éxito!");
    }

    static void MostrarCliente()
    {
        Console.Write("\nIngrese el nombre del cliente: ");
        string nombre = Console.ReadLine();

        foreach (Cliente c in clientes)
        {
            if (c.Nombre == nombre)
            {
                Console.WriteLine("\n--- Detalles del cliente ---");
                Console.WriteLine($"Nombre: {c.Nombre}");
                Console.WriteLine($"Edad: {c.Edad}");
                Console.WriteLine($"Teléfono: {c.Telefono}");
                Console.WriteLine($"Membresía: {c.Membresia}");
                return;
            }
        }
        Console.WriteLine("Cliente no encontrado");
    }

    static void ListarClientes()
    {
        Console.WriteLine("\n--- Lista de clientes ---");
        foreach (Cliente c in clientes)
        {
            Console.WriteLine($"- {c.Nombre} ({c.Membresia})");
        }
    }

    static void BuscarCliente()
    {
        Console.Write("\nIngrese nombre a buscar: ");
        string nombre = Console.ReadLine();
        bool encontrado = false;

        foreach (Cliente c in clientes)
        {
            if (c.Nombre.Contains(nombre))
            {
                Console.WriteLine($"- {c.Nombre} ({c.Membresia})");
                encontrado = true;
            }
        }

        if (!encontrado)
            Console.WriteLine("No se encontraron coincidencias");
    }

    static void BajaCliente()
    {
        Console.Write("\nIngrese el nombre del cliente a eliminar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].Nombre == nombre)
            {
                clientes.RemoveAt(i);
                Console.WriteLine("Cliente eliminado");
                return;
            }
        }
        Console.WriteLine("Cliente no encontrado");
    }

    static void ModificarCliente()
    {
        Console.Write("\nIngrese el nombre del cliente a modificar: ");
        string nombre = Console.ReadLine();

        foreach (Cliente c in clientes)
        {
            if (c.Nombre == nombre)
            {
                Console.WriteLine("\nIngrese los nuevos datos (dejar en blanco para no modificar)");

                Console.Write("Nuevo nombre: ");
                string nuevoNombre = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoNombre))
                    c.Nombre = nuevoNombre;

                Console.Write("Nueva edad: ");
                string nuevaEdad = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevaEdad))
                    c.Edad = Convert.ToInt32(nuevaEdad);

                Console.Write("Nuevo teléfono: ");
                string nuevoTel = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoTel))
                    c.Telefono = nuevoTel;

                Console.Write("Nueva membresía: ");
                string nuevaMemb = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevaMemb))
                    c.Membresia = nuevaMemb;

                Console.WriteLine("Datos actualizados!");
                return;
            }
        }
        Console.WriteLine("Cliente no encontrado");
    }
}