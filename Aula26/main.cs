
//ARGUMENTO OUT 
using System;

class Programm
{
	static void Main()
	{
		int dvd = 10;
		int dvr = 6;

		int resto;
		
		int quoc = dividir(dvd, dvr, out resto);
		
		Console.WriteLine("O valor do Quociente de {0} por {1} é {2}", dvd, dvr, quoc);
		Console.WriteLine("O valor do Resto de {0} por {1} é {2}", dvd, dvr, resto);
	}
	
	static int dividir(int dividendo, int divisor, out int resto)
	{
		resto = (dividendo%divisor);
		int quoc = (dividendo/divisor);
		
		return quoc;
	}
}