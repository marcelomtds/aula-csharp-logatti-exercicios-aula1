using System;

namespace Ex10
{
    class Program
    {
        static Habitante[] habitantes;
        static int quantidadeHabitantes = 4;
        static double menorSalario = 150.00;
        static double maiorSalario = 0.00;
        static void Main(string[] args)
        {
            habitantes = new Habitante[quantidadeHabitantes];
            for (int i = 0; i < quantidadeHabitantes; i++)
            {
                Habitante habitante = new Habitante();
                Console.Write($"Informe o salário do {i + 1}º habitante: ");
                habitante.salario = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Informe a quantidade de filho do {i + 1}º habitante: ");
                habitante.quantidadeFilho = Convert.ToInt16(Console.ReadLine());
                habitantes[i] = habitante;
            }
            calcular();
            calcularMaiorSalario();
        }

        static void calcularMaiorSalario()
        {
            for (int i = 0; i < quantidadeHabitantes; i++)
            {
                if (habitantes[i].salario > maiorSalario)
                {
                    maiorSalario = habitantes[i].salario;
                }
            }
            Console.WriteLine($"Maior salário dos habitantes: R$ {(maiorSalario).ToString(".00")}.");
        }

        static void calcular()
        {
            double totalSalario = 0.0;
            int totalFilho = 0;
            double salarioMenor = 0.0;
            int quantidadeSalarioMenor = 0;
            for (int i = 0; i < quantidadeHabitantes; i++)
            {
                if (habitantes[i].salario < menorSalario)
                {
                    salarioMenor += habitantes[i].salario;
                    quantidadeSalarioMenor++;
                }
                totalSalario += habitantes[i].salario;
                totalFilho += habitantes[i].quantidadeFilho;
            }
            Console.WriteLine($"Média de salário da população: R$ {totalSalario / quantidadeHabitantes}.");
            Console.WriteLine($"Média do número de filhos da população: {Math.Round(Convert.ToDouble(totalFilho / quantidadeHabitantes))}.");
            Console.WriteLine($"Percentual de pessoas com salário menor que R$ 150,00: {100 * quantidadeSalarioMenor / quantidadeHabitantes}%.");
        }

    }

    public class Habitante
    {
        public int quantidadeFilho;
        public double salario;
    }
}
