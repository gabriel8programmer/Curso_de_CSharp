
//LOOP WHILE
using System;

class Programm
{
	static void Main()
	{
		string nome;
		int c = 0;
		int tamVetor = 5;
		
		string[] vetNomes = new string[tamVetor];
		
		while (c < tamVetor)
		{
			Console.Write("Digite um nome para cadastrar: ");
			nome = Console.ReadLine();
			vetNomes[c] = nome;
			c++;
		}
		
		Console.WriteLine("\n===========================================\n");
		Console.WriteLine(".......< 5 CADASTROS >........ ");
		Console.WriteLine("\n===========================================\n");
		for (c=0; c<tamVetor; c++)
		{
			Console.WriteLine("=> {0, 20}", vetNomes[c]);
		}
	}
}