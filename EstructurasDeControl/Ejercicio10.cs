using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la nota (0 - 100): ");
        int nota = int.Parse(Console.ReadLine());

        // Validación
        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("Error: La nota debe estar entre 0 y 100.");
            return;
        }

        string letra;
        string descripcion;
        string estado;

        if (nota >= 90)
        {
            letra = "A";
            descripcion = "Excelente";
        }
        else if (nota >= 80)
        {
            letra = "B";
            descripcion = "Muy Bueno";
        }
        else if (nota >= 70)
        {
            letra = "C";
            descripcion = "Bueno";
        }
        else if (nota >= 60)
        {
            letra = "D";
            descripcion = "Regular";
        }
        else
        {
            letra = "F";
            descripcion = "Deficiente";
        }

        if (nota >= 65)
            estado = "Aprobó";
        else
            estado = "Reprobó";

        Console.WriteLine(" \nResultado:");
        Console.WriteLine("Nota: " + nota);
        Console.WriteLine("Letra: " + letra);
        Console.WriteLine("Descripción: " + descripcion);
        Console.WriteLine("Estado: " + estado);
    }
}
}