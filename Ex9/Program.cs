using System;

namespace Ex9
{
    class Program
    {
        static Produto[] produtos;
        static double soma;
        static int qtd = 3;
        static double maiorPreco = 0.0;
        static void Main(string[] args)
        {
            produtos = new Produto[qtd];
            soma = 0.0;
            for (int i = 0; i < qtd; i++)
            {
                Produto produto = new Produto();
                Console.Write($"Informe o código do {i + 1}º produto: ");
                produto.codigo = Console.ReadLine();
                Console.Write($"Informe o preço do {i + 1}º produto: ");
                produto.preco = Convert.ToDouble(Console.ReadLine());
                produtos[i] = produto;
                soma = soma + produtos[i].preco;
            }
            MaiorPreco();
            Console.WriteLine($"O maior preço lido foi R$ {(maiorPreco).ToString(".00")}.");
            Console.Write($"A média do preço dos produtos foi de R$ {(soma / qtd).ToString(".00")}.");
        }

        static void MaiorPreco()
        {
            for (int i = 0; i < qtd; i++)
            {
                for (int j = 0; j < qtd - 1; j++)
                {
                    if (produtos[i].preco > maiorPreco)
                    {
                        maiorPreco = produtos[i].preco;
                    }
                }
            }
        }

    }
    public class Produto
    {
        public string codigo;
        public double preco;
    }

}
