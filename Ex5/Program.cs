using System;

namespace Ex5
{
    class Program
    {
        private static Pessoa pessoa = new Pessoa();
        private static double resultado;
        static void Main(string[] args)
        {
            LerDados();
            Calcular();
            ImprimirResultado();
        }

        private static void ImprimirResultado()
        {
            Console.Write($"O peso ideal para {pessoa.nome} é de {resultado.ToString(".00")} kg.");
        }

        private static void LerDados()
        {
            Console.Write("Informe o nome: ");
            pessoa.nome = Console.ReadLine();
            Console.Write("Informe a altura (ex: 1,95): ");
            pessoa.altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o sexo (m ou f): ");
            pessoa.sexo = Convert.ToChar(Console.ReadLine());
        }

        private static void Calcular()
        {
            resultado = pessoa.sexo == 'm' ? (72.7 * pessoa.altura) - 58 : (62.1 * pessoa.altura) - 44.7;
        }
    }

    class Pessoa
    {
        public string nome { get; set; }
        public double altura { get; set; }
        public char sexo { get; set; }
    }
}
