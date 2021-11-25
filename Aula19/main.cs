
//LOOP FOR
using System;

class Programm
{
	static void Main()
	{
		Console.WriteLine("===========================================");
		Console.WriteLine("Contagem de 1 a 10...");
		Console.WriteLine("===========================================");
		for (int c = 1; c <= 10; c++)
		{
			Console.Write("{0,3}", c);
		}
		Console.WriteLine("\n===========================================");
		Console.WriteLine("Contagem de 10 a 1...");
		Console.WriteLine("===========================================");
		
		for (int c = 10; c >= 1; c--)
		{
			Console.Write("{0,3}", c);
		}
		Console.WriteLine("\n===========================================");
	}
}