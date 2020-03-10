using System;

namespace Ex2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Informe o total de votos em brancos: ");
			int brancos = Convert.ToInt16(Console.ReadLine());
			Console.Write("Informe o total de votos nulos: ");
			int nulos = Convert.ToInt16(Console.ReadLine());
			Console.Write("Informe o total de votos válidos: ");
			int validos = Convert.ToInt16(Console.ReadLine());
			double total = brancos + nulos + validos;
			Console.WriteLine($"Votos em branco: {((brancos / total) * 100).ToString("0.00")}%");
			Console.WriteLine($"Votos nulos: {((nulos / total) * 100).ToString("0.00")}%");
			Console.WriteLine($"Votos válidos: {((validos / total) * 100).ToString("0.00")}%");
		}
	}
}
