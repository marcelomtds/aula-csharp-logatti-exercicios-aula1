using System;

namespace Ex7
{
    class Program
    {
        private static double[] numeros = new double[3];
        private static double maior = 0.0;
        static void Main(string[] args)
        {
            LerValores();
            ImprimirResultado();
        }

        private static void ImprimirResultado()
        {
            Console.Write($"O número {maior} foi o maior número informado.");
        }

        private static void LerValores()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º número: ");
                CalcularMaior(Convert.ToDouble(Console.ReadLine()));
            }
        }

        static void CalcularMaior(double numero)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }
    }
}
