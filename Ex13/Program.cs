using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Informe um número (maior que zero): ");
            numero = Convert.ToInt16(Console.ReadLine());
            Console.Write($"Imprimindo números entre 1 e {numero}: ");
            for (int i = 1; i <= numero; i++)
            {
                string separador = i < numero ? ", " : ".";
                Console.Write(i + separador);
            }
        }
    }
}
