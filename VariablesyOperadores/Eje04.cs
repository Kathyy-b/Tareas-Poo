using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VariablesyOperadores
{
    public class Eje04
    {
        static void Main()
        {
            double monto, TasaAnual, InterésTotal, TotalPagar, CuotaPréstamo;
            int meses;

        Console.WriteLine("---INGRESE MONTO DE PRÉSTAMO---");
        monto = Console.ToDouble(Console,ReadLine());
         Console.WriteLine("Ingrese la tasa de Interés anual");
         monto = Console.ToDouble(Console.ReadLine());
         Console.WriteLine("Ingrese el plazo en meses");
         meses = Convert.ToInt32(Console.ReadLine());

         InterésTotal = monto * (TasaAnual / 100) * (meses / 12.0);
         TotalPagar = monto + InterésTotal;
         CuotaMensual = TotalPagar / meses;


        Console.WriteLine("---RESULTADO---");
        Console.WriteLine("Interés Total : L." + InterésTotal);
        Console.WriteLine("Total a pagar : L." + CuotaMensual);
        Console.WriteLine("CuotaMensual : L." + CuotaMensual);


        }
    }
}