using System;

namespace Ex11
{
    class Program
    {
        private static double[] temperaturas = new double[5];
        private static double somaTemperaturas = 0.0;
        static void Main(string[] args)
        {
            LerDados();
            Calcular();
            ImprimirResultado();
        }
        private static void Calcular()
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                for (int j = 0; j < temperaturas.Length - 1; j++)
                {
                    if (temperaturas[i] > temperaturas[j])
                    {
                        double auxiliar = temperaturas[i];
                        temperaturas[i] = temperaturas[j];
                        temperaturas[j] = auxiliar;
                    }
                }
                somaTemperaturas += temperaturas[i];
            }
        }
        private static void LerDados()
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Informe a {i + 1}ª temperatura: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        private static void ImprimirResultado()
        {
            Console.WriteLine($"Menor temperatura: {temperaturas[temperaturas.Length - 1]}");
            Console.WriteLine($"Maior temperatura: {temperaturas[0]}");
            Console.WriteLine($"Temperatura média: {(somaTemperaturas / temperaturas.Length).ToString("0.00")}");
        }
    }
}
