using System;

namespace Ex13
{
    class Program
    {
        private static int numero = 0;
        static void Main(string[] args)
        {
            LerDados();
            ImprimirResultado();
        }

        private static void ImprimirResultado()
        {
            Console.Write($"Imprimindo números entre 1 e {numero}: ");
            for (int i = 1; i <= numero; i++)
            {
                string separador = i < numero ? ", " : ".";
                Console.Write(i + separador);
            }
        }

        private static void LerDados()
        {
            while (numero < 1)
            {
                Console.Write("Informe um número (maior que zero): ");
                numero = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}
