using System;

namespace Ex2
{
    class Program
    {
        private static int votosBrancos;
        private static int votosNulos;
        private static int votosValidos;
        private static double total;
        static void Main(string[] args)
        {
            votosBrancos = LerVotos("branco");
            votosNulos = LerVotos("nulo");
            votosValidos = LerVotos("válido");
            total = votosBrancos + votosNulos + votosValidos;
            ImprimirResultado("branco", votosBrancos);
            ImprimirResultado("nulo", votosNulos);
            ImprimirResultado("válido", votosValidos);
        }

        private static int LerVotos(String texto)
        {
            Console.Write($"Informe o total de votos em {texto}: ");
            return Convert.ToInt16(Console.ReadLine());
        }
        private static void ImprimirResultado(String texto, int votos)
        {
            Console.WriteLine($"Votos em {texto}: {((votos / total) * 100).ToString("0.00")}%");
        }
    }
}
