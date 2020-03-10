using System;

namespace Ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Informe a data de nascimento (ex: 04/04/1991): ");
			TimeSpan resultado = Convert.ToDateTime(DateTime.Now.Date.ToString()) - Convert.ToDateTime(Console.ReadLine());
			Console.WriteLine(resultado.Days);
			Console.ReadKey();
		}
	}
}
