using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o sexo (m ou f): ");
            char sexo = Convert.ToChar(Console.ReadLine());
            double resultado = sexo == 'm' ? (72.7 * altura) - 58 : (62.1 * altura) - 44.7;
            Console.Write($"O peso ideal para {nome} é de {resultado.ToString(".00")} kg.");
        }
    }
}
