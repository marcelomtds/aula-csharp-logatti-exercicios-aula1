using System;

namespace Ex10
{
    class Program
    {
        private static Habitante[] habitantes = new Habitante[4];
        private static double menorSalario = 150.00;

        static void Main(string[] args)
        {
            LerDados();
            ImprimirResultado();
        }
        private static void LerDados()
        {
            for (int i = 0; i < habitantes.Length; i++)
            {
                Habitante habitante = new Habitante();
                Console.Write($"Informe o salário do {i + 1}º habitante: ");
                habitante.salario = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Informe a quantidade de filho do {i + 1}º habitante: ");
                habitante.quantidadeFilho = Convert.ToInt16(Console.ReadLine());
                habitantes[i] = habitante;
            }
        }

        private static double CalcularMaiorSalario()
        {
            double maiorSalario = 0.0;
            for (int i = 0; i < habitantes.Length; i++)
            {
                if (habitantes[i].salario > maiorSalario)
                {
                    maiorSalario = habitantes[i].salario;
                }
            }
            return maiorSalario;
        }
        private static double CalcularMediaSalario()
        {
            double salarioTotal = 0.0;
            for (int i = 0; i < habitantes.Length; i++)
            {
                salarioTotal += habitantes[i].salario;
            }
            return salarioTotal / habitantes.Length;
        }
        private static double CalcularMediaFilho()
        {
            int total = 0;
            for (int i = 0; i < habitantes.Length; i++)
            {
                total += habitantes[i].quantidadeFilho;
            }
            return Math.Round(Convert.ToDouble(total / habitantes.Length));
        }

        private static double CalcularPercentualMenorSalario()
        {
            double total = 0;
            int quantidade = 0;
            for (int i = 0; i < habitantes.Length; i++)
            {
                if (habitantes[i].salario < menorSalario)
                {
                    total += habitantes[i].salario;
                    quantidade++;
                }
            }
            return 100 * quantidade / habitantes.Length;
        }
        private static void ImprimirResultado()
        {
            Console.WriteLine($"Maior salário dos habitantes: R$ {CalcularMaiorSalario().ToString(".00")}.");
            Console.WriteLine($"Média de salário da população: R$ {CalcularMediaSalario().ToString(".00")}.");
            Console.WriteLine($"Média do número de filhos da população: {CalcularMediaFilho()}.");
            Console.WriteLine($"Percentual de pessoas com salário menor que R$ 150,00: {CalcularPercentualMenorSalario().ToString(".00")}%.");
        }

    }
    class Habitante
    {
        public int quantidadeFilho { get; set; }
        public double salario { get; set; }
    }
}
