
//ARGUMENTO PARAMS
using System;

class Programm
{
	static void Main()
	{
		double[] notas = new double[5];
		double media;
		
		int contNotas = notas.Length;
		
		double soma;
		
		Console.Write("Digite o Nome do Aluno(a): ");
		string nome = Console.ReadLine();
		
		for (int c = 0; c < notas.Length; c++)
		{
			Console.Write("Digite a {0}º nota do(a) {1}: ", (c+1), nome);
			notas[c] = double.Parse(Console.ReadLine());
		}
		
		soma = somarNotas(notas[0], notas[1], notas[2], notas[3], notas[4]);	
		
		media = (soma/contNotas);
		
		desenharLinha();
		Console.WriteLine("Ao todo foram {0} notas somadas", notas.Length);
		Console.WriteLine("Resultado da soma: {0}", soma);
		Console.WriteLine("Resultado da Média: {0}", media);
		desenharLinha();
	}
	
	static double somarNotas(params double[] notas)
	{
		double soma = 0;
		
		for (int c=0; c < notas.Length; c++)
		{
			soma += notas[c];
		}
		return soma;
	}
	
	static void desenharLinha()
	{
		Console.WriteLine("=================================================================");
	}
}