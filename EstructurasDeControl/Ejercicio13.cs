using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
    public class Ejercicio13
    {
    static void Main()
    {
        int dia, mes, año, diasMes = 0;
        bool bisiesto = false;

        Console.Write("Ingrese el día: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el año: ");
        año = int.Parse(Console.ReadLine());

        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("Fecha inválida.");
            return;
        }

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
        {
            bisiesto = true;
        }

        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 ||
            mes == 8 || mes == 10 || mes == 12)
        {
            diasMes = 31;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            diasMes = 30;
        }
        else if (mes == 2)
        {
            if (bisiesto)
                diasMes = 29;
            else
                diasMes = 28;
        }

        if (dia >= 1 && dia <= diasMes)
        {
            Console.WriteLine("La fecha es válida.");
        }
        else
        {
            Console.WriteLine("La fecha es inválida.");
        }
    }
}
    }