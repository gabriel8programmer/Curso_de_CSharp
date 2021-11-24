
//COMANDO IF
using System;

class Programm
{
	static void Main()
	{
		
		string nome;
		
		double nota1;
		double nota2;
		double soma;
		double media;
		
		Console.Write("Digite o nome de um Aluno(a): ");
		nome = Console.ReadLine();
		
		Console.Write("Digite a 1º nota de {0}: ", nome);
		nota1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Digite a 2º nota de {0}: ", nome);
		nota2 = Convert.ToDouble(Console.ReadLine());
		
		soma = (nota1 + nota2);
		media = (soma/2);
		
		//se o teste lógico for true então apresenta a msg
		if (media >= 7){
			Console.WriteLine("===========================================================");
			Console.WriteLine("A média de {0} é {1}!", nome, media);
			Console.WriteLine("===========================================================");
		}
		
	}
}