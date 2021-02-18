using System.Globalization;

namespace Application
{
    class CalculadoraIMC
    {
        public double Peso, Altura;
        
        public double ResultadoIMC()
        {
            return Peso / (Altura * Altura);
        }

        
    }
}
