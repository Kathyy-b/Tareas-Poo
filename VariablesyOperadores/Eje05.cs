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
        Console.WriteLine("Hora inicial (HH:mm:ss): ");
        string HoraInicialTexto = Console.ReadLine();

        Console.WriteLine("Hora final (HH:mm:ss): ");
        string HoraFinalTexto = Console.ReadLine();

        int h1 = int.Parse(hora1[0]);
        int m1 = int.Parse(hora1[1]);
        int s1 = int.Parse(hora1[2]);

        int h2 = int.Parse(hora2[0]);
        int m2 = int.Parse(hora2[1]);
        int s2 = int.Parse(hora2[2]);

        if (h2 < h1 || (h2 == h1 && m2 < m1) || (h2 == h1 && m2 == m1 && s2 < s1))
        {
            h2 += 24;
        }

        if (s2 < s1)
        {
            s2 += 60;
            m2--;
        }

        int segundos = s2 - s1;

        if (m2 < m1)
        {
            m2 += 60;
            h2--;
        }

        int minutos = m2 - m1;
        int horas = h2 - h1;

        Console.WriteLine($"Tiempo transcurrido: {horas:D2}:{minutos:D2}:{segundos:D2}");
    }
}
}