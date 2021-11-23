
//CONSTANTES 
using System;

class Programm{
	static void Main(){
		const string nome = "Gabriel";
		const int anoNasc = 2003;
		int idade = (2021 - anoNasc);
		
		Console.WriteLine("Nome: {0}", nome);
		Console.WriteLine("Você nasceu em {0} então você tem {1} anos!", anoNasc, idade);
	}
}