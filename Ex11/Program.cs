using System;

namespace Ex11
{
    class Program
    {
        static int quantidade = 5;
        static double[] temperaturas;
        static void Main(string[] args)
        {
            temperaturas = new double[5];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Informe a {i + 1}ª temperatura: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }
            Calcular();
        }

        static void Calcular()
        {
            double totalTemperatura = 0.0;
            for (int i = 0; i < quantidade; i++)
            {
                for (int j = 0; j < quantidade - 1; j++)
                {
                    if (temperaturas[i] > temperaturas[j])
                    {
                        double auxiliar = temperaturas[i];
                        temperaturas[i] = temperaturas[j];
                        temperaturas[j] = auxiliar;
                    }
                }
                totalTemperatura += temperaturas[i];
            }
            Console.WriteLine($"Menor temperatura: {temperaturas[temperaturas.Length - 1]}.");
            Console.WriteLine($"Maior temperatura: {temperaturas[0]}.");
            Console.WriteLine($"Temperatura média: {(totalTemperatura / quantidade).ToString("0.00")}");
        }
    }
}
