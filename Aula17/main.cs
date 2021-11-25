
//ARRAYS 
using System;

class Programm
{
	static void Main()
	{
		int[] v1 = new int[3];
		int[] v2 = new int[3]{4, 5, 6};
		int[] v3 = {7, 8, 9};
		
		v1[0] = 1;
		v1[1] = 2;
		v1[2] = 3;
		
		Console.WriteLine("[{0, 3}, {1, 3}, {2, 3}]", v1[0], v1[1], v1[2]);
		Console.WriteLine("[{0, 3}, {1, 3}, {2, 3}]", v2[0], v2[1], v2[2]);
		Console.WriteLine("[{0, 3}, {1, 3}, {2, 3}]", v3[0], v3[1], v3[2]);
	}
}