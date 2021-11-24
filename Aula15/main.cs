
//COMANDO SWITCH CASE
using System;

class Programm
{
	static void Main()
	{
		int numRodas;
		string veiculo = null;
		
		Console.Write("Digite um número de rodas: ");
		numRodas = Convert.ToInt32(Console.ReadLine());
		
		switch(numRodas)
		{
			case 1:
				veiculo = "Monocícliculo!";
				break;
			case 2:
				veiculo = "Bícicleta ou moto!";
				break;
			case 3:
				veiculo = "Tríciculo!";
				break;
			case 4:
				veiculo = "Carro";
				break;
			default:
				veiculo = "ônibus";
				break;
		}
		
		Console.WriteLine("==============================================");
		Console.WriteLine("Esse veículo pode ser um(a) {0}", veiculo);
	}
}