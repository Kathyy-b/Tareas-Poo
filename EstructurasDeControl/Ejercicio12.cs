using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
    public class Ejercicio12
    {
    static void Main()
    {
        int año, mes, dias = 0;
        bool bisiesto = false;

        Console.Write("Ingrese el año: ");
        año = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el mes (1-12): ");
        mes = int.Parse(Console.ReadLine());

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
        {
            bisiesto = true;

        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 ||
            mes == 8 || mes == 10 || mes == 12)
        {
            dias = 31;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            dias = 30;
        }
        else if (mes == 2)
        {
            if (bisiesto)
                dias = 29;
            else
                dias = 28;
        }
        else
        {
            Console.WriteLine("Mes inválido.");
            return;
        }

        if (bisiesto)
            Console.WriteLine("El año es bisiesto.");
        else
            Console.WriteLine("El año no es bisiesto.");

        Console.WriteLine("El mes tiene " + dias + " días.");
    }
}
    }
}