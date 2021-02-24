using System;

class Vertailu
{
	static void Main()
	{
		int x, y;

		Console.WriteLine("Syötä ensimmäinen numero: ");
		x = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Syötä toinen numero: ");
		y = Convert.ToInt32(Console.ReadLine());
		
		if (x > y)
		{
			Console.WriteLine("Numero 1 on suurempi kuin numero 2.");
		} else if (y > x) {
			Console.WriteLine("Numero 2 on suurempi kuin numero 1.");
		} else {
			Console.WriteLine("Numerot ovat yhtä suuret.");
		}
	}
}
	
	
