
//COMANDO GOTO
using System;

class Programm
{
	static void Main()
	{
		int numero;
		char opc;
		
		pergunta:
		Console.Write("Digite um número: ");
		numero = int.Parse(Console.ReadLine());
		
		Console.Write("Quer continuar [S/N]? ");
		opc = char.Parse(Console.ReadLine());
		
		if ((opc == 's')||(opc == 'S'))
		{
			goto pergunta;
		}
	}
}