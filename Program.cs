using System;

class SistemaGestionClientes
{
    private static string[] colaCircular;
    private static int frente = -1;
    private static int final = -1;
    private const int CapacidadMaxima = 5;

    static void Main()
    {
        InicializarCola();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n=== Sistema de Gestión de Atención al Cliente ===");
            Console.WriteLine("1. Agregar cliente a la cola");
            Console.WriteLine("2. Atender siguiente cliente");
            Console.WriteLine("3. Salir del sistema");
            Console.Write("Seleccione opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AgregarCliente();
                    break;
                case "2":
                    ProcesarCliente();
                    break;
                case "3":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Entrada inválida. Seleccione una opción válida.");
                    break;
            }

            MostrarEstadoCola();
        }

        Console.WriteLine("\nSistema finalizado correctamente.");
    }

    static void InicializarCola()
    {
        colaCircular = new string[CapacidadMaxima];
        frente = -1;
        final = -1;
    }

    /// <summary>
    /// Cola circular Fifo
    /// </summary>
    static void AgregarCliente()
    {
        if ((final + 1) % CapacidadMaxima == frente)
        {
            Console.WriteLine("Capacidad máxima alcanzada. No se pueden agregar más clientes.");
            return;
        }

        Console.Write("Ingrese nombre del cliente: ");
        string nombreCliente = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(nombreCliente))
        {
            Console.WriteLine("Nombre inválido. El campo no puede estar vacío.");
            return;
        }

        if (frente == -1) frente = 0;
        final = (final + 1) % CapacidadMaxima;
        colaCircular[final] = nombreCliente;

        Console.WriteLine($"Cliente '{nombreCliente}' agregado a la cola.");
    }

    /// <summary>
    /// FIFO
    /// </summary>
    static void ProcesarCliente()
    {
        if (frente == -1)
        {
            Console.WriteLine("La cola está vacía. No hay clientes por atender.");
            return;
        }

        string clienteProcesado = colaCircular[frente];
        colaCircular[frente] = null;

        if (frente == final)
        {
            frente = -1;
            final = -1;
        }
        else
        {
            frente = (frente + 1) % CapacidadMaxima;
        }

        Console.WriteLine($"Atendiendo cliente: {clienteProcesado}");
    }

    /// <summary>
    /// Muestra el estado actual de la cola 
    /// </summary>
    static void MostrarEstadoCola()
    {
        Console.WriteLine("\n[ESTADO DE LA COLA]");
        if (frente == -1)
        {
            Console.WriteLine("No hay clientes en espera");
            return;
        }

        int posicion = 1;
        int indice = frente;

        do
        {
            Console.WriteLine($"{posicion}. {colaCircular[indice]}");
            indice = (indice + 1) % CapacidadMaxima;
            posicion++;
        } while (indice != (final + 1) % CapacidadMaxima);

        Console.WriteLine($"Clientes en espera: {posicion - 1}");
    }
}