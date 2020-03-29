using System;

namespace Ex8
{
    class Program
    {
        private static double a;
        private static double b;
        private static double c;
        private static bool isTriangulo;
        static void Main(string[] args)
        {
            a = LerValor("A");
            b = LerValor("B");
            c = LerValor("C");
            Calcular();
            ImprimirResultado();
        }

        private static void ImprimirResultado()
        {
            string texto = isTriangulo ? "Forma" : "Não forma";
            Console.Write($"{texto} um triângulo.");
        }

        private static void Calcular()
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                isTriangulo = true;
            }
            else
            {
                isTriangulo = false;
            }
        }

        private static double LerValor(string texto)
        {
            Console.Write($"Informe o valor de {texto}: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
