
//MÉTODO
using System;

class Programm
{
	static void Main()
	{
		int a, b;
		
		a = lerInt("Digite um valor: ");
		b = lerInt("Digite outro valor: ");
		desenharLinha(20, '=');
		Console.WriteLine("{0,3} + {1,3} = {2,3}", a, b, somar(a,b));
		desenharLinha(20, '=');
	}
	
	static int lerInt(string msg)
	{
		Console.Write(msg);
		int numero = int.Parse(Console.ReadLine());
		return numero;
	}
	
	static int somar(int n1, int n2)
	{
		return (n1+n2);
	}
	
	static void desenharLinha(int tamanho, char formaLinha)
	{
		Console.Write("+");
		for (int c = 1; c <= tamanho; c++)
		{
			Console.Write(formaLinha);
		}
		Console.WriteLine("+");
	}
}