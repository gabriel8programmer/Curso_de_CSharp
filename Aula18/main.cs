
//MATRIZES
using System;

class Programm
{
	static void Main()
	{
		int[,] mat1 = new int[2,2];
		int[,] mat2 = new int[2,2]{{5, 6}, {7, 8}};
		int[,] mat3 = {{9, 10}, {11, 12}};
		
		mat1[0,0] = 1;
		mat1[0,1] = 2;
		mat1[1,0] = 3;
		mat1[1,1] = 4;
		
		Console.WriteLine("[{0, 3},{1, 3},{2, 3},{3, 3}]", mat1[0,0], mat1[0,1], mat1[1,0], mat1[1,1]);
		Console.WriteLine("[{0, 3},{1, 3},{2, 3},{3, 3}]", mat2[0,0], mat2[0,1], mat2[1,0], mat2[1,1]);
		Console.WriteLine("[{0, 3},{1, 3},{2, 3},{3, 3}]", mat3[0,0], mat3[0,1], mat3[1,0], mat3[1,1]);
		
	}
}