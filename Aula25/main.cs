
//PASSAGEM DE PARÂMETROS POR VALOR E POR REFERENCIA
using System;

class Programm
{
	static void Main()
	{
		string txt = "HELLO WORLD!";
		Console.WriteLine("Texto Original: {0}", txt);
		trocarTexto(ref txt);
		Console.WriteLine("Texto Mudado: {0}", txt);
	}
	
	static void trocarTexto(ref string txt)
	{
		txt = "OLÁ, MUNDO!";
	}
}