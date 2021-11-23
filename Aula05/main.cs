
//ESCOPO DE VARIÁVEIS
using System;

class Programm{
	
	static int numero = 100;//variável global a classe programm
	
	static void Main(){
		int numero1 = 50;//variável local ao método main
		
		Console.WriteLine("Número Global: " + numero);
		Console.WriteLine("Número Local : " + numero1);
	}
	
}
