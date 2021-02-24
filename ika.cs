using System;

class ika
{
	static void Main()
	{
		int ika;
		
		Console.WriteLine("Syötä ikäsi, ole hyvä: ");
		ika = Convert.ToInt32(Console.ReadLine());
		
		if (ika > 17)
		{
			Console.WriteLine("Voit äänestää!");
		}
	}
}
