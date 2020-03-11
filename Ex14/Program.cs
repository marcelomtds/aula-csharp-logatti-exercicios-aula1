using System;

namespace Ex14
{
    class Program
    {
        static int inicial = 15;
        static int final = 100;
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = inicial; i <= final; i++)
            {
                soma += i;
            }
            Console.WriteLine("Média: " + soma / (final - inicial));
        }
    }
}
