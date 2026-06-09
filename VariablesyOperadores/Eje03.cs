using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VariablesyOperadores
{
    public class Eje03
    {
        static void Main()
        {
            int monto;
            Console.WriteLine("Ingrese monto en lempiras. ");
            monto = Convert.ToInt(Console.ReadLine());

            int[] billetes = {500, 100, 50, 20, 10, 5, 2, 1};
            Console.WriteLine("desenglose de billetes . ");

            for (int i = 0; i < billetes.Length; i ++)
            {
               int cantidad = monto/billetes[i];

               if(cantidad > 0);
            }
            {
                Console.WriteLine("L ." + billetes[i] + " : " + cantidad);
                monto %= billetes[i];
            }


        }
    }
}