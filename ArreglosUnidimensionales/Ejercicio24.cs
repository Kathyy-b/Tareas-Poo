using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArreglosUnidimensionales
{
    public class Ejercicio24
    {
         public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 24:");
            Console.WriteLine("Busqueda y Ordenamiento");
            int[] numeros = new int[10];

            Console.WriteLine("Ingrese 10 numeros enteros:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Numero #{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Valor invalido. Ingrese un numero entero: ");
                }
            }

            Console.Write("Ingrese el numero que desea buscar: ");
            int buscado;
            bool encontrado = false;

            while (!int.TryParse(Console.ReadLine(), out buscado))
            {
                Console.Write("Valor invalido. Ingrese un numero entero: ");
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine("Numero encontrado en la posicion {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Numero no encontrado en el arreglo.");
            }
            int mayor = int.MinValue;
            int segundoMayor = int.MinValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    segundoMayor = mayor;
                    mayor = numeros[i];
                }
                else if (numeros[i] > segundoMayor && numeros[i] != mayor)
                {
                    segundoMayor = numeros[i];
                }
            }

            Console.WriteLine("El segundo mayor es: {segundoMayor}");

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temporal = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temporal;
                    }
                }
            }

            Console.WriteLine("\nArreglo ordenado de forma ascendente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("\n\nElementos en posiciones pares (indice par):");

            for (int i = 0; i < numeros.Length; i += 2)
            {
                Console.Write(numeros[i] + " ");
            }

            Pausa();
        }

 private void Pausa()
        {
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
        }
    
    }
}