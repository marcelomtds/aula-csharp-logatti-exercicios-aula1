using System;

namespace Ex12
{
    class Program
    {
        private static int quantidade = 10;
        private static double total = 0.0;
        static void Main(string[] args)
        {
            LerDados();
            ImprimirResultado();
        }
        private static void ImprimirResultado()
        {
            Console.WriteLine($"Soma total: {total}");
        }
        private static void LerDados()
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Informe o {i + 1}º número: ");
                total += Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
