using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
    public class Ejercicio14
    {
    static void Main()
    {
        int saldo = 5000; 
        int retiro;

        Console.Write("Ingrese el monto a retirar: ");
        retiro = int.Parse(Console.ReadLine());

        if (retiro <= 0)
        {
            Console.WriteLine("Monto inválido.");
            return;
        }

        if (retiro % 20 != 0)
        {
            Console.WriteLine("El monto debe ser múltiplo de 20.");
            return;
        }

        if (retiro > saldo)
        {
            Console.WriteLine("Fondos insuficientes.");
            return;
        }

        saldo -= retiro;

        Console.WriteLine("\nRetiro aprobado.");
        Console.WriteLine("Nuevo saldo: L " + saldo);

        int[] billetes = { 200, 100, 50, 20 };

        Console.WriteLine("\nDesglose de billetes:");

        for (int i = 0; i < billetes.Length; i++)
        {
            int cantidad = retiro / billetes[i];
            if (cantidad > 0)
            {
                Console.WriteLine(cantidad + " billete(s) de L " + billetes[i]);
                retiro = retiro % billetes[i];
            }
        }
    }
}    }
