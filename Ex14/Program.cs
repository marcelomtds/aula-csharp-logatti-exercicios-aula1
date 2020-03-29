using System;

namespace Ex14
{
    class Program
    {
        private static double media = 0.0;
        private static int inicial = 15;
        private static int final = 100;
        static void Main(string[] args)
        {
            Calcular();
            ImprimirResultado();
        }
        private static void Calcular()
        {
            double soma = 0.0;
            for (int i = inicial; i <= final; i++)
            {
                soma += i;
            }
            media = soma / (final - inicial);
        }
        private static void ImprimirResultado()
        {
            Console.WriteLine($"Média aritmética entre {inicial} (inclusive) e {final} (inclusive): {media.ToString(".00")}");
        }
    }
}