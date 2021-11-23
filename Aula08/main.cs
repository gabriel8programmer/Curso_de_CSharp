
//LER VALORES DO TECLADO
using System;

class Programm{
	static void Main(){
		string nome;
		int idade;
		
		Console.Write("Digite Seu Nome : ");
		nome = Console.ReadLine();
		Console.Write("Digite Sua Idade: ");
		idade = int.Parse(Console.ReadLine());
		
		Console.WriteLine("\nMeu nome é {0} e eu tenho {1} anos de Idade!", nome, idade);
	}
}