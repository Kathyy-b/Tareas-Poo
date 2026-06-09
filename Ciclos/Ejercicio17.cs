using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ciclos
{
    public class Ejercicio17
{
    static void Main()
    {
        int n;
        int a = 0, b = 1, siguiente;
        double suma = 0;

        Console.Write("Ingrese la cantidad de términos: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nSerie Fibonacci:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            suma += a;

            siguiente = a + b;
            a = b;
            b = siguiente;
        }

        double promedio = suma / n;

        Console.WriteLine("\nSuma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }
}
    }
