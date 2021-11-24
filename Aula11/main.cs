
//TYPE CAST
using System;

class Programm{
	
	static void Main(){
		
		double nota1 = 10.05;
		double nota2 = 30.40;
		int nota3 = 20;
		float nota4 = 29.83432f;
		int nota5 = (int)nota4;
		
		nota1 = (double)nota3;
		nota3 = (int)nota2;
		nota2 = nota1;
		
		Console.WriteLine("Nota 1: {0}", nota1);
		Console.WriteLine("Nota 2: {0}", nota2);
		Console.WriteLine("Nota 3: {0}", nota3);
		Console.WriteLine("Nota 4: {0}", nota4);
		Console.WriteLine("Nota 5: {0}", nota5);
		
		
	}
}