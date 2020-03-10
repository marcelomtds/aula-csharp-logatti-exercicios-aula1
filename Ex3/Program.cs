using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double custoFabrica;
            double custoConsumidor;
            double porcentagemDistribuidor = 28.0;
            double percentualImpostos = 45.0;
            double destribuidor;
            double valorImpostos;
            Console.Write("Informe o custo de fábrica de um carro novo: R$ ");
            custoFabrica = Convert.ToDouble(Console.ReadLine());
            destribuidor = custoFabrica + (custoFabrica * porcentagemDistribuidor / 100);
            valorImpostos = custoFabrica + (custoFabrica * percentualImpostos / 100);
            custoConsumidor = custoFabrica + destribuidor + valorImpostos;
            Console.Write("O custo ao consumidor de um carro novo é de R$ " + custoConsumidor);
        }
    }
}
