using System;
using System.ComponentModel.Design.Serialization;

namespace VariablesyOperadores
{
    class CalculadoraIMC
{
    private double peso;
    private double altura;
    private double imc;

    // Constructor
    public CalculadoraIMC(double peso, double altura)
    {
        this.peso = peso;
        this.altura = altura;
        this.imc = peso / (altura * altura);
    }

    public void MostrarResultado()
    {
        Console.WriteLine($"IMC: {imc:F2}");

        if (imc < 18.5)
        {
            Console.WriteLine("Categoría: Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Categoría: Normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Categoría: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Categoría: Obesidad");
        }
    }
}
}

