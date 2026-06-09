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
        double horasTrabajadas, tarifaHora;
        double horasNormales, horasExtras;
        double pagoNormal, pagoExtra, salarioTotal;

        Console.WriteLine("=== Cálculo de Salario Semanal ===");

        Console.Write("Ingrese las horas trabajadas: ");
        horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tarifa por hora: ");
        tarifaHora = Convert.ToDouble(Console.ReadLine());

        if (horasTrabajadas > 44)
        {
            horasNormales = 44;
            horasExtras = horasTrabajadas - 44;
        }
        else
        {
            horasNormales = horasTrabajadas;
            horasExtras = 0;
        }

        pagoNormal = horasNormales * tarifaHora;
        pagoExtra = horasExtras * tarifaHora * 1.5;
        salarioTotal = pagoNormal + pagoExtra;

        Console.WriteLine("\n--- Desglose del Salario ---");
        Console.WriteLine("Horas normales: " + horasNormales);
        Console.WriteLine("Horas extras: " + horasExtras);
        Console.WriteLine("Pago por horas normales: L. " + pagoNormal);
        Console.WriteLine("Pago por horas extras: L. " + pagoExtra);
        Console.WriteLine("Salario total: L. " + salarioTotal);
    }
}
}