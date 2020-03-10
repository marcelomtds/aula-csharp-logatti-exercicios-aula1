using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário fixo: R$ ");
            double salarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o total de vendas: R$ ");
            double totalVenda = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o total de carros vendidos: ");
            int qtdCarroVendido = Convert.ToInt16(Console.ReadLine());
            Console.Write("Informe o valor da comissão: R$ ");
            double comissao = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Salário final: R$ {(salarioFixo + (comissao * qtdCarroVendido) + (totalVenda * 0.05)).ToString(".00")}");
        }
    }
}
