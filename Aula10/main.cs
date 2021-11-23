
//ENUMERADORES
using System;

class Programm{
	
	enum Direct{RIGHT, LEFT, UP, DOWN};
	
	static void Main(){
		
		Direct d1 = Direct.RIGHT;
		int    d2 = (int)Direct.LEFT;
		string d3 = Convert.ToString(Direct.UP);
		Object d4 = (int)Direct.DOWN;//aqui poderia usar o cast tanto de int quanto de string
		
		Console.WriteLine("O valor de D1 é {0}", d1);
		Console.WriteLine("O valor de D2 é {0}", (Direct)d2);//usando o cast para uma conversão
		Console.WriteLine("O valor de D3 é {0}", d3);
		Console.WriteLine("O valor de D4 é {0}", (Direct)d4);//usando o cast para uma conversão
		
	}
}