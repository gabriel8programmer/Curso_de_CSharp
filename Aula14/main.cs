

//COMANDO IF ANINHADO 
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
		
		string res;
		
		Console.Write("Digite o nome de um Aluno(a): ");
		nome = Console.ReadLine();
		
		Console.Write("Digite a 1º nota de {0}: ", nome);
		nota1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Digite a 2º nota de {0}: ", nome);
		nota2 = Convert.ToDouble(Console.ReadLine());
		
		soma = (nota1 + nota2);
		media = (soma/2);
		
		if (media >= 9)
		{
			res = "APROVADO(a). PARABÉNS CONTINUE ASSIM!";
		}
		else if (media >= 7)
		{
			res = "APROVADO(a). POR POUCO ESTUDE MAIS!";
		}
		else if (media >= 5)
		{
			res = "RECUPERAÇÃO. ESTUDE MAIS!";
		}
		else if (media >= 3)
		{
			res = "REPROVADO(a)";
		}
		else 
		{
			res = "REPROVADISSIMO(a). TE VEJO NO ANO QUE VEM...";
		}
		
		Console.WriteLine("===========================================================");
		Console.WriteLine("A média de {0} é {1}!\nResultado: {2}", nome, media, res);
		Console.WriteLine("===========================================================");
		
	}
}