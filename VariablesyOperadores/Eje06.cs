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
        int opcion;

        do
        {
            Console.WriteLine(" === Cálculo de área y perímetro de figuras ===");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Trapecio");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Circulo();
                    break;

                case 2:
                    Triangulo();
                    break;

                case 3:
                    Rectangulo();
                    break;

                case 4:
                    Trapecio();
                    break;

                case 5:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 5);
    }

    static double LeerPositivo(string mensaje)
    {
        double valor;

        do
        {
            Console.Write(mensaje);
            valor = double.Parse(Console.ReadLine());

            if (valor <= 0)
                Console.WriteLine("Error: el valor debe ser positivo.");

        } while (valor <= 0);

        return valor;
    }

    static void Circulo()
    {
        double radio = LeerPositivo("Ingrese el radio: ");

        double area = Math.PI * radio * radio;
        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine($"Área: {area:F2}");
        Console.WriteLine($"Perímetro: {perimetro:F2}");
    }

    static void Triangulo()
    {
        double baseTri = LeerPositivo("Ingrese la base: ");
        double altura = LeerPositivo("Ingrese la altura: ");

        double lado1 = LeerPositivo("Ingrese lado 1: ");
        double lado2 = LeerPositivo("Ingrese lado 2: ");
        double lado3 = LeerPositivo("Ingrese lado 3: ");

        double area = (baseTri * altura) / 2;
        double perimetro = lado1 + lado2 + lado3;

        Console.WriteLine($"Área: {area:F2}");
        Console.WriteLine($"Perímetro: {perimetro:F2}");
    }

    static void Rectangulo()
    {
        double baseRect = LeerPositivo("Ingrese la base: ");
        double altura = LeerPositivo("Ingrese la altura: ");

        double area = baseRect * altura;
        double perimetro = 2 * (baseRect + altura);

        Console.WriteLine($"Área: {area:F2}");
        Console.WriteLine($"Perímetro: {perimetro:F2}");
    }

    static void Trapecio()
    {
        double baseMayor = LeerPositivo("Ingrese la base mayor: ");
        double baseMenor = LeerPositivo("Ingrese la base menor: ");
        double altura = LeerPositivo("Ingrese la altura: ");

        double lado1 = LeerPositivo("Ingrese lado 1: ");
        double lado2 = LeerPositivo("Ingrese lado 2: ");

        double area = ((baseMayor + baseMenor) * altura) / 2;
        double perimetro = baseMayor + baseMenor + lado1 + lado2;

        Console.WriteLine($"Área: {area:F2}");
        Console.WriteLine($"Perímetro: {perimetro:F2}");
    }
}
}
