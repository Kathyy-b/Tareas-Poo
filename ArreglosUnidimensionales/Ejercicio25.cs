using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArreglosUnidimensionales
{
    public class Ejercicio25
    {
          public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 25:");
            Console.WriteLine("Rotacion de Arreglo");
            int cantidadElementos;

            Console.Write("Ingrese la cantidad de elementos: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadElementos) || cantidadElementos <= 0)
            {
                Console.Write("Valor invalido. Ingrese un numero mayor que 0: ");
            }

            int[] elementos = new int[cantidadElementos];

            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.Write($"Elemento #{i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out elementos[i]))
                {
                    Console.Write("Valor invalido. Ingrese un numero entero: ");
                }
            }

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Rotar K posiciones a la izquierda");
            Console.WriteLine("2. Rotar K posiciones a la derecha");
            Console.WriteLine("3. Invertir arreglo");
            Console.Write("Seleccione una opcion: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.Write("Opcion invalida. Ingrese 1, 2 o 3: ");
            }

            if (opcion == 1 || opcion == 2)
            {
                Console.Write("Ingrese el valor de K: ");
                int posiciones;

                while (!int.TryParse(Console.ReadLine(), out posiciones) || posiciones < 0)
                {
                    Console.Write("Valor invalido. Ingrese un numero positivo: ");
                }

                posiciones = posiciones % cantidadElementos;

                if (opcion == 1)
                {

                    for (int r = 0; r < posiciones; r++)
                    {
                        int primero = elementos[0];

                        for (int i = 0; i < cantidadElementos - 1; i++)
                        {
                            elementos[i] = elementos[i + 1];
                        }

                        elementos[cantidadElementos - 1] = primero;
                    }
                }
                else
                {
                    for (int r = 0; r < posiciones; r++)
                    {
                        int ultimo = elementos[cantidadElementos - 1];

                        for (int i = cantidadElementos - 1; i > 0; i--)
                        {
                            elementos[i] = elementos[i - 1];
                        }

                        elementos[0] = ultimo;
                    }
                }
            }
            else
            {
                for (int i = 0; i < cantidadElementos / 2; i++)
                {
                    int temporal = elementos[i];
                    elementos[i] = elementos[cantidadElementos - 1 - i];
                    elementos[cantidadElementos - 1 - i] = temporal;
                }
            }

            Console.WriteLine("\nResultado final del arreglo:");

            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.Write(elementos[i] + " ");
            }

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}