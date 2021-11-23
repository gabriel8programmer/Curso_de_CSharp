
//OPERAÇÕES DE BITWISE
using System;

class Programm{
	static void Main(){
		int val1;
		int val2;
		int val3;
		
		Console.Write("Digite um Valor.....: ");
		val1 = int.Parse(Console.ReadLine());
		Console.Write("Digite Outro Valor..: ");
		val2 = int.Parse(Console.ReadLine());
		Console.Write("Digite Outro Valor..: ");
		val3 = Convert.ToInt32(Console.ReadLine());
		
		val1 = val1 << 1; //dobrar valor de val1
		val2 = val2 << 1; //dobrar valor de val2
		val3 = val3 << 1; //dobrar valor de val3
		
		Console.WriteLine("======================================================");
		Console.WriteLine("................... VALORES DOBRADOS .................");
		Console.WriteLine("======================================================");
		Console.WriteLine("Valor_1: {0}", val1);
		Console.WriteLine("Valor_2: {0}", val2);
		Console.WriteLine("Valor_3: {0}", val3);
		Console.WriteLine("======================================================");
		
		val1 = val1 >> 1; //metade do valor de val1
		val2 = val2 >> 1; //metade do valor de val2
		val3 = val3 >> 1; //metade do valor de val3
		
		Console.WriteLine("======================================================");
		Console.WriteLine(".................. VALORES NA METADE .................");
		Console.WriteLine("======================================================");
		Console.WriteLine("Valor_1: {0}", val1);
		Console.WriteLine("Valor_2: {0}", val2);
		Console.WriteLine("Valor_3: {0}", val3);
		Console.WriteLine("======================================================");
		
	}
}