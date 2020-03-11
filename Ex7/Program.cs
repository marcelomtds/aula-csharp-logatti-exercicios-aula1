using System;

namespace Ex7
{
    class Program
    {
        static double[] numeros = new double[3];
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
            Console.Write($"Informe o {i + 1}º número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
                numeros[i] = numero;
            }
            ordenarVetor();
            Console.Write($"O número {numeros[0]} é o maior número informado.");
        }

        static void ordenarVetor()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length - 1;j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        double aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }

            }
        }
    }
}
