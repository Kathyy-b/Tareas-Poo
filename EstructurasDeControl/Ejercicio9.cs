using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
class Program
{
    public void Main()
    {
        double a, b, c;

        Console.WriteLine("=== Clasificación de Triángulos ===");

        Console.Write("Ingrese el lado 1: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el lado 2: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el lado 3: ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("\nEs un triángulo válido.");

            if (a == b && b == c)
                Console.WriteLine("Tipo por lados: Equilátero");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Tipo por lados: Isósceles");
            else
                Console.WriteLine("Tipo por lados: Escaleno");

            double x = a, y = b, z = c;

            if (x > y) { double temp = x; x = y; y = temp; }
            if (y > z) { double temp = y; y = z; z = temp; }
            if (x > y) { double temp = x; x = y; y = temp; }

            double sumaCuadrados = x * x + y * y;
            double mayorCuadrado = z * z;

            if (sumaCuadrados == mayorCuadrado)
                Console.WriteLine("Tipo por ángulos: Rectángulo");
            else if (sumaCuadrados > mayorCuadrado)
                Console.WriteLine("Tipo por ángulos: Acutángulo");
            else
                Console.WriteLine("Tipo por ángulos: Obtusángulo");
        }
        else
        {
            Console.WriteLine("\nLos lados ingresados NO forman un triángulo válido.");
        }
    }
}
}