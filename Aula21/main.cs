
//LOOP DO WHILE
using System;

class Programm
{
	static void Main()
	{
		int c = 0;
		string[] veiculos = new string[10];
		
		veiculos[0] = "--Avião---------";
		veiculos[1] = "--Carro---------";
		veiculos[2] = "--Trem----------";
		veiculos[3] = "--Bicicleta-----";
		veiculos[4] = "--Moto----------";
		veiculos[5] = "--Quadricículo--";
		veiculos[6] = "--Monocículo----";
		veiculos[7] = "--Skate---------";
		veiculos[8] = "--Van-----------";
		veiculos[9] = "--ônibus--------";
		
		Console.WriteLine("\n===================================\n");
		Console.WriteLine("---------< VEICULOS >---------");
		Console.WriteLine("\n===================================\n");
		
		do 
		{
			Console.WriteLine("=> {0, 20}", veiculos[c]);
			c++;
		}while(c < 10);
		
		Console.WriteLine("\n===================================\n");
	}
}