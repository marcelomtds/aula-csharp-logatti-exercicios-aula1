using System;

namespace Ex12
{
    class Program
    {
        static int quantidade = 10;
        static void Main(string[] args)
        {
            double total = 0.0;
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Informe o {i + 1}º número: ");
                total += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Soma total: {total}.");
        }
    }
}
