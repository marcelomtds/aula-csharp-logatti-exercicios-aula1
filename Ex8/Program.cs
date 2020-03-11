using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.Write("Forma um triângulo.");
            }
            else
            {
                Console.Write("Não forma um triângulo.");
            }
        }
    }
}
