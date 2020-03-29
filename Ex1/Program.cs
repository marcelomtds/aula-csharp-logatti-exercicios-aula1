using System;

namespace Ex1
{
    class Program
    {
        private static TimeSpan resultado;
        static void Main(string[] args)
        {
            ReceberDataNascimento();
            ImprimirResultado();
        }

        private static void ReceberDataNascimento()
        {
            Console.Write("Informe a data de nascimento (ex: 04/04/1991): ");
            resultado = Convert.ToDateTime(DateTime.Now.Date.ToString()) - Convert.ToDateTime(Console.ReadLine());
        }
        private static void ImprimirResultado()
        {
            Console.WriteLine($"Idade em dias: {resultado.Days}");
        }

    }
}
