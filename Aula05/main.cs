
//OPERADORES E SUAS OPERAÇÕES 
using System;

class Programm{
	
	static void Main(){
		
		int n1 = 10; 
		int n2 =  5;
		
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine("          OPERADORES MATEMÁTICOS             ");
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine(n1 + " + " + n2 + " = " + (n1+n2) );
		Console.WriteLine(n1 + " - " + n2 + " = " + (n1-n2) );
		Console.WriteLine(n1 + " * " + n2 + " = " + (n1*n2) );
		Console.WriteLine(n1 + " / " + n2 + " = " + (n1/n2) );
		Console.WriteLine(n1 + " % " + n2 + " = " + (n1%n2) );
		Console.WriteLine("---------------------------------------------\n");
		
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine("          OPERADORES RELACIONAIS             ");
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine(n1 + " >  " + n2 + " = " + (n1>n2) );
		Console.WriteLine(n1 + " <  " + n2 + " = " + (n1<n2) );
		Console.WriteLine(n1 + " >= " + n2 + " = " + (n1>=n2) );
		Console.WriteLine(n1 + " <= " + n2 + " = " + (n1<=n2) );
		Console.WriteLine(n1 + " == " + n2 + " = " + (n1==n2) );
		Console.WriteLine(n1 + " != " + n2 + " = " + (n1!=n2) );
		Console.WriteLine("---------------------------------------------\n");
		
		Console.WriteLine("------------------------------------------------------------");
		Console.WriteLine("          OPERADORES DE INCREMENTO E DECREMENTO             ");
		Console.WriteLine("------------------------------------------------------------");
		Console.WriteLine("n1++  = " +  n1++);
		Console.WriteLine("n2--  = " +  n2--);
		Console.WriteLine("------------------------------------------------------------");
		
		Console.WriteLine("--------------------------------------------------------------------");
		Console.WriteLine("          OPERADORES DE POS-INCREMENTO E POS-DECREMENTO             ");
		Console.WriteLine("--------------------------------------------------------------------");
		Console.WriteLine("++n1  = " +  ++n1);
		Console.WriteLine("++n2  = " +  --n2);
		Console.WriteLine("--------------------------------------------------------------------");
		
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine("          OPERADORES LÓGICOS                 ");
		Console.WriteLine("---------------------------------------------");
		bool certo;
		certo = ( n1 > n2 & ((n2 - 2) == 10));
		Console.WriteLine("Certo = " + certo);
		certo = ( n1 > n2 | ((n2 - 2) == 10));
		Console.WriteLine("Certo = " + certo);
		certo = (!((n2+n1) > 20));
		Console.WriteLine("Certo = " + certo);
		Console.WriteLine("---------------------------------------------\n");
	}
	
}