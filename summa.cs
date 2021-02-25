using System;

class Summa
{
	static void Main()
	{
		int syote, summa = 0;
		
		while (summa <= 200)
		{
			Console.Write("Summa on nyt " + summa + ". Syöte: ");
			syote = Convert.ToInt32(Console.ReadLine());
			
			summa += syote;
			
			if (summa >= 200)
			{
				break;
			}
		}
		
		Console.WriteLine("Saavutettiin 200. Summa oli " + summa + ".");
	}
}
