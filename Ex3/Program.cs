using System;

namespace Ex3
{
    class Program
    {
        private static double custoFabrica;
        private static double custoConsumidor;
        private static double porcentagemDistribuidor = 28.0;
        private static double percentualImpostos = 45.0;
        private static double destribuidor;
        private static double valorImpostos;
        static void Main(string[] args)
        {
            LerValor();
            Calcular();
            ImprimirResultado();
        }

        private static void LerValor()
        {
            Console.Write("Informe o custo de fábrica de um carro novo: R$ ");
            custoFabrica = Convert.ToDouble(Console.ReadLine());
        }
        private static void Calcular()
        {
            destribuidor = custoFabrica + (custoFabrica * porcentagemDistribuidor / 100);
            valorImpostos = custoFabrica + (custoFabrica * percentualImpostos / 100);
            custoConsumidor = custoFabrica + destribuidor + valorImpostos;
        }
        private static void ImprimirResultado()
        {
            Console.Write("O custo ao consumidor de um carro novo é de R$ " + custoConsumidor);
        }

    }
}
