using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ciclos
{
    public class Ejercicio16
    {
    static void Main()
    {
        int inicio, fin, contador = 0;

        Console.Write("Ingrese el inicio del rango: ");
        inicio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el fin del rango: ");
        fin = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nNúmeros primos:");

        for (int num = inicio; num <= fin; num++)
        {
            int divisores = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                Console.WriteLine(num);
                contador++;
            }
        }

        Console.WriteLine("\nCantidad de números primos: " + contador);
    }
}
    }