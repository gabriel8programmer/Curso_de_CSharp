
//FOREACH
using System;

class Programm
{
	enum semana{SEGUNDA, TERÇA, QUARTA, QUINTA, SEXTA, SABADO, DOMINGO};
	
	static void Main()
	{
		semana[] mat = {semana.SEGUNDA, semana.SABADO, semana.DOMINGO, semana.QUARTA};
		
		Console.WriteLine("\n============================\n");
		Console.WriteLine("---< DIAS DA SEMANA >---");
		Console.WriteLine("\n============================\n");
		foreach(semana m in mat)
		{
			Console.WriteLine("=> {0,20}", m);
		}
		Console.WriteLine("\n============================\n");
	}
}