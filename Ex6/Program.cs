using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário fixo: R$ ");
            double salarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor total das vendas: R$ ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());
            if (totalVendas <= 1500)
            {
                Console.Write($"O salário total é de R$ {(totalVendas * 0.03 + salarioFixo).ToString(".00")}");
            }
            else
            {
                Console.Write($"O salário total é de R$ {((totalVendas * 0.03 + salarioFixo) + ((totalVendas - 1500) * 0.05)).ToString(".00")}");
            }
        }
    }
}
