using System;
using System.Globalization;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraIMC imc = new CalculadoraIMC();

            Console.Write("Digite seu peso: ");
            imc.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Digite sua altura: ");
            imc.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            double res = imc.ResultadoIMC();
            Console.WriteLine("Seu IMC é: " + res.ToString("F1", CultureInfo.InvariantCulture));

            if (res < 18.5)
            {
                Console.WriteLine("Baixo peso!");
            }
            if (res >= 18.5 && res <= 24.9)
            {
                Console.WriteLine("Peso normal!");
            }
            if (res >= 25 && res <= 29.9)
            {
                Console.WriteLine("Sobre peso!");
            }
            if (res >= 30.0)
            {
                Console.WriteLine("Obesidade!");
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }
    }
}
