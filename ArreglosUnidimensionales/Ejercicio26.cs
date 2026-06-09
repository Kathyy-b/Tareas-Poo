using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArreglosUnidimensionales
{
    public class Ejercicio26
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 26:");
            Console.WriteLine("Frecuencia de Elementos");
            int[] numeros = new int[20];
            int[] frecuencia = new int[11]; 

            Random random = new Random();

            // Generar numeros aleatorios del 1 al 10
            Console.WriteLine("Numeros generados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 11);
                Console.Write(numeros[i] + " ");

                frecuencia[numeros[i]]++; 
            }

            Console.WriteLine("\n\nFrecuencia de cada numero:");

            int masFrecuente = 1;
            int menosFrecuente = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Numero {i}: {frecuencia[i]} veces");

                if (frecuencia[i] > frecuencia[masFrecuente])
                {
                    masFrecuente = i;
                }

                if (frecuencia[i] < frecuencia[menosFrecuente])
                {
                    menosFrecuente = i;
                }
            }

            Console.WriteLine($"Numero mas frecuente: {masFrecuente} ({frecuencia[masFrecuente]} veces)");
            Console.WriteLine($"Numero menos frecuente: {menosFrecuente} ({frecuencia[menosFrecuente]} veces)");

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}