using System;

namespace Ex4
{
    class Program
    {
        private static double salarioFixo;
        private static double totalVendas;
        private static int qtdCarroVendido;
        private static double comissao;
        private static double resultado;
        static void Main(string[] args)
        {
            salarioFixo = LerValorDouble("salário fixo: R$");
            totalVendas = LerValorDouble("total de vendas: R$");
            qtdCarroVendido = LerValorInt("total de carros vendidos:");
            comissao = LerValorDouble("valor da comissão: R$");
            CalcularResultado();
            ImprimirResultado();
        }

        private static double LerValorDouble(string texto)
        {
            Console.Write($"Informe o {texto} ");
            return Convert.ToDouble(Console.ReadLine());
        }
        private static int LerValorInt(string texto)
        {
            Console.Write($"Informe o {texto} ");
            return Convert.ToInt16(Console.ReadLine());
        }
        private static void CalcularResultado()
        {
            resultado = salarioFixo + (comissao * qtdCarroVendido) + (totalVendas * 0.05);
        }
        private static void ImprimirResultado()
        {
            Console.Write($"Salário final: R$ {resultado.ToString(".00")}");
        }

    }
}
