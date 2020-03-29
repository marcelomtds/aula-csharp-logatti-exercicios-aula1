using System;

namespace Ex6
{
    class Program
    {
        private static double salarioFixo;
        private static double totalVendas;
        private static double resultado;
        static void Main(string[] args)
        {
            salarioFixo = LerDados("o salário fixo: R$");
            totalVendas = LerDados("valor total das vendas: R$");
            Calcular();
            ImprimirResultado();
        }

        private static void ImprimirResultado()
        {
            Console.Write($"O salário total é de R$ {resultado.ToString(".00")}");
        }

        private static void Calcular()
        {
            if (totalVendas <= 1500)
            {
                resultado = totalVendas * 0.03 + salarioFixo;
            }
            else
            {
                resultado = (totalVendas * 0.03 + salarioFixo) + ((totalVendas - 1500) * 0.05);
            }
        }

        private static double LerDados(string texto)
        {
            Console.Write($"Informe o {texto} ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
