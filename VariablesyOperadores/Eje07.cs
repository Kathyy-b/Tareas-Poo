using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VariablesyOperadores
{
class Program
{
    static void Main()
    {
        double valor;
        int opcionOrigen, opcionDestino;

        Console.WriteLine("=== Conversor de Unidades de Almacenamiento ===");

        Console.WriteLine("\nUnidades disponibles:");
        Console.WriteLine("1. Bytes");
        Console.WriteLine("2. KB");
        Console.WriteLine("3. MB");
        Console.WriteLine("4. GB");
        Console.WriteLine("5. TB");

        Console.Write("\nSeleccione la unidad de origen: ");
        opcionOrigen = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Seleccione la unidad de destino: ");
        opcionDestino = Convert.ToInt32(Console.ReadLine());

        // Convertir primero a bytes
        double bytes = valor;

        switch (opcionOrigen)
        {
            case 1: bytes = valor; break;
            case 2: bytes = valor * 1024; break;
            case 3: bytes = valor * 1024 * 1024; break;
            case 4: bytes = valor * 1024 * 1024 * 1024; break;
            case 5: bytes = valor * 1024 * 1024 * 1024 * 1024; break;
            default:
                Console.WriteLine("Unidad de origen no válida.");
                return;
        }

        // Convertir desde bytes a la unidad destino
        double resultado = bytes;

        switch (opcionDestino)
        {
            case 1: resultado = bytes; break;
            case 2: resultado = bytes / 1024; break;
            case 3: resultado = bytes / (1024 * 1024); break;
            case 4: resultado = bytes / (1024 * 1024 * 1024); break;
            case 5: resultado = bytes / (1024 * 1024 * 1024 * 1024); break;
            default:
                Console.WriteLine("Unidad de destino no válida.");
                return;
        }

        Console.WriteLine($"\nResultado: {resultado} ");
    }
}
}
