
//MÉTODOS DE ARRAYS
using System;

class Programm
{
	static void Main()
	{
		int[] v1 = new int[5];
		int[] v2 = new int[5];
		int[] v3 = {20, 45, 172, 94, 0};
		
		Random rand = new Random();
		
		//atribuindo as posições do vetor 1 valores aleatórios
		for (int c=0; c < v1.Length; c++)
		{
			v1[c] = rand.Next(101);
		}
		
		//atribuindo as posições do vetor 1 valores aleatórios
		for (int c=0; c < v2.Length; c++)
		{
			v2[c] = rand.Next(101);
		}
		
		Console.Clear();
		//mostrar valores de vetor 1
		foreach (int v in v1)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//mostrar valores de vetor 2
		foreach (int v in v2)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//mostrar valores de vetor 2
		foreach (int v in v3)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//método BinarySearch(object[] vet, int pos)
		Console.WriteLine(" < BynarySearch >");
		int procurado = 100;
		Console.WriteLine("Valor {0} encontrado na posição {1} do vetor 1!", procurado, Array.BinarySearch(v1, procurado));
		
		Console.WriteLine("\n================================================\n");
		
		//método Copy(vetor1, vetor2, qtd_elementos)
		Console.WriteLine(" < Copy >");
		int qtd_elementos = v2.Length;
		Array.Copy(v2, v1, qtd_elementos);
		//mostrar valores de vetor 1
		Console.WriteLine(" < Novos Valores de V1 >");
		foreach (int v in v1)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//método CopyTo(vetor1, indice)
		Console.WriteLine(" < CopyTo >");
		int comece = 0;
		v1.CopyTo(v3, comece);
		//mostrar valores de vetor 3
		Console.WriteLine(" < Novos Valores de V3 >");
		foreach (int v in v3)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//método GetLongLength(dimensão)
		Console.WriteLine(" < GetLongLength >");
		Console.WriteLine("Tamanho do vetor 1: {0}", v1.GetLongLength(0));
		
		Console.WriteLine("\n================================================\n");
		
		
		//método GetLowerBound(dimensão)
		Console.WriteLine(" < GetLowerBound >");
		Console.WriteLine(" < Valores de V2 >");
		foreach (int v in v2)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		int menVal = v2.GetLowerBound(0);
		Console.WriteLine("Menor indice do vetor 2: {0} ", menVal);
		
		Console.WriteLine("\n================================================\n");
		
		//método GetUpperBound(dimensão)
		Console.WriteLine(" < GetLowerBound >");
		Console.WriteLine(" < Valores de V2 >");
		foreach (int v in v2)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		int maiVal = v2.GetUpperBound(0);
		Console.WriteLine("Maior indice do vetor 2: {0} ", maiVal);
		
		Console.WriteLine("\n================================================\n");
		
		//método GetValue(long valor)
		Console.WriteLine(" < GetValue >");
		Console.WriteLine(" < Valores de V3 >");
		foreach (int v in v3)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		int indice1 = 3;
		int val1 = Convert.ToInt32(v3.GetValue(indice1));
		Console.WriteLine("Valor {0} encontrado na posição {1} do vetor 3!", val1, indice1);
		
		Console.WriteLine("\n================================================\n");
		
		//método IndexOf(long valor)
		Console.WriteLine(" < IndexOf >");
		Console.WriteLine(" < Valores de V3 >");
		foreach (int v in v3)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		int val2 = 80;
		int indice2 = Array.IndexOf(v3, val2);
		Console.WriteLine("Valor {0} encontrado na posição {1} do vetor 3!", val2, indice2);
		
		Console.WriteLine("\n================================================\n");
		
		//método LastIndexOf(long valor)
		Console.WriteLine(" < LastIndexOf >");
		Console.WriteLine(" < Valores de V3 >");
		foreach (int v in v3)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		int val3 = 80;
		int indice3 = Array.IndexOf(v3, val3);
		Console.WriteLine("Valor {0} por ultimo encontrado na posição {1} do vetor 3!", val3, indice3);
		
		Console.WriteLine("\n================================================\n");
		
		//método Reverse(array)
		Console.WriteLine(" < Reverse >");
		Array.Reverse(v1);
		Console.WriteLine(" < Valores de V1 Invertidos >");
		foreach (int v in v1)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//método setValue(valor, pos)
		Console.WriteLine(" < SetValue > ");
		v1.SetValue(20, 0);
		Console.WriteLine("Valor do indice 0 de v1 = {0}", v1[0]);
		
		Console.WriteLine("\n================================================\n");
		
		//método Sort()
		Array.Sort(v1);
		Array.Sort(v2);
		Array.Sort(v3);
		
		Console.WriteLine("Vetores Ordenados: ");
		
		//mostrar valores de vetor 1
		foreach (int v in v1)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//mostrar valores de vetor 2
		foreach (int v in v2)
		{
			Console.WriteLine("|{0,3}|", v);
		}
		
		Console.WriteLine("\n================================================\n");
		
		//mostrar valores de vetor 2
		foreach (int v in v3)
		{
			Console.WriteLine("|{0,3}|", v);
		}
	}
}