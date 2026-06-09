using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace VariablesyOperadores
{
    public class Conversiondetemperatura
    {
        static void Main(String[] args)
        {

            Console.WriteLine("---CONVERSOR DE TEMPERATURA---");
            Console.WriteLine("1. Celsius a fahrenheit");
            Console.WriteLine("2.fahrenheit a Celcius");
            Console.WriteLine("3.Celcius a Kelvin");
            Console.WriteLine("4.Kelvin a Celcius");

            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Temperatura : ");
            double temperatura = double.Parse(Console.ReadLine());
            double resultado = 0;

            switch (opcion)
            {
                case 1:
                resultado = (TemperaturaInput * 1.8) + 32;
                Console.WriteLine($"{temperaturaInput}°C equivale a {resultado}°F");
                break;

                case 2:
                resultado = (TemperaturaInput - 32) /1.8;
                Console.WriteLine($"{TemperaturaInput} °F equivale a {resultado}°C");
                break;

                case 3:
                resultado =(TemperaturaInput + 273.15);
                Console.WriteLine($"{TemperaturaInput} °C equivale a {resultado} °K");
                break;

                case 4:
                resultado = (TemperaturaInput - 273.15);
                Console.WriteLine($"{TemperaturaInput} °K equivale a {resultado} °C");
                break;

              default:
              Console.WriteLine("Opción no válida. ");
              break;

            }


        }
    }
}