using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArreglosBidimensionales
{
    public class Ejercicio30
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 30:");
            Console.WriteLine("Inventario Simple");

            // codigos, nombres, cantidades, precios almacenan la informacion de cada producto

            int[] codigos = new int[5];
            string[] nombres = new string[5];
            int[] cantidades = new int[5];
            double[] precios = new double[5];

            // Ingreso inicial de productos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Producto " + (i + 1));
                Console.Write("Codigo: ");
                codigos[i] = int.Parse(Console.ReadLine());

                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Cantidad: ");
                cantidades[i] = int.Parse(Console.ReadLine());

                Console.Write("Precio: ");
                precios[i] = double.Parse(Console.ReadLine());
            }

            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. Buscar producto");
                Console.WriteLine("3. Actualizar cantidad");
                Console.WriteLine("4. Calcular valor total del inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("INVENTARIO:");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Codigo: " + codigos[i] +
                                          " | Nombre: " + nombres[i] +
                                          " | Cantidad: " + cantidades[i] +
                                          " | Precio: " + precios[i]);
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese el codigo a buscar: ");
                    int codigoBusqueda = int.Parse(Console.ReadLine());
                    bool productoEncontrado = false;

                    for (int i = 0; i < 5; i++)
                    {
                        if (codigos[i] == codigoBusqueda)
                        {
                            Console.WriteLine("Producto encontrado:");
                            Console.WriteLine("Nombre: " + nombres[i]);
                            Console.WriteLine("Cantidad: " + cantidades[i]);
                            Console.WriteLine("Precio: " + precios[i]);
                            productoEncontrado = true;
                        }
                    }

                    if (!productoEncontrado)
                        Console.WriteLine("Producto no encontrado.");
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese el codigo del producto: ");
                    int codigoBusqueda = int.Parse(Console.ReadLine());
                    bool productoEncontrado = false;

                    for (int i = 0; i < 5; i++)
                    {
                        if (codigos[i] == codigoBusqueda)
                        {
                            Console.Write("Nueva cantidad: ");
                            cantidades[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cantidad actualizada.");
                            productoEncontrado = true;
                        }
                    }

                    if (!productoEncontrado)
                        Console.WriteLine("Producto no encontrado.");
                }
                else if (opcion == 4)
                {
                    double valorTotalInventario = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        valorTotalInventario += cantidades[i] * precios[i];
                    }

                    Console.WriteLine("Valor total del inventario: " + valorTotalInventario);
                }
                else if (opcion != 5)
                {
                    Console.WriteLine("Opcion invalida.");
                }
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