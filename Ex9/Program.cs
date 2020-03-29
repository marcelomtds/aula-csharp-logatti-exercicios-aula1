using System;

namespace Ex9
{
    class Program
    {
        private static Produto[] produtos = new Produto[3];
        static void Main(string[] args)
        {
            LerDados();
            ImprimirResultado();
        }

        private static void ImprimirResultado()
        {
            Console.WriteLine($"O maior preço lido foi R$ {VerificarMaiorPreco().ToString(".00")}.");
            Console.Write($"A média do preço dos produtos foi de R$ {CalcularMedia().ToString(".00")}.");
        }

        private static double CalcularMedia()
        {
            double soma = 0.0;
            for (int i = 0; i < produtos.Length; i++)
            {
                soma += produtos[i].preco;
            }
            return soma / produtos.Length;
        }

        private static void LerDados()
        {
            for (int i = 0; i < produtos.Length; i++)
            {
                Produto produto = new Produto();
                Console.Write($"Informe o código do {i + 1}º produto: ");
                produto.codigo = Console.ReadLine();
                Console.Write($"Informe o preço do {i + 1}º produto: ");
                produto.preco = Convert.ToDouble(Console.ReadLine());
                produtos[i] = produto;
            }
        }

        private static double VerificarMaiorPreco()
        {
            double maiorPreco = 0.0;
            for (int i = 0; i < produtos.Length; i++)
            {
                if (produtos[i].preco > maiorPreco)
                {
                    maiorPreco = produtos[i].preco;
                }
            }
            return maiorPreco;
        }

    }
    public class Produto
    {
        public string codigo { get; set; }
        public double preco { get; set; }
    }

}
