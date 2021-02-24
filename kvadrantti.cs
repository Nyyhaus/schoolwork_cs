using System;

class Koordinaatti
{
	static void Main()
	{
		int x, y;
		
		Console.WriteLine("Löydä xy-akseleilla olevan pisteen kvadrantti:");
		Console.Write("X-koordinaatti: ");
		x = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Y-koordinaatti: ");
		y = Convert.ToInt32(Console.ReadLine());
		
		if (x == 0 && y == 0)
		{
			Console.WriteLine("Koordinaattipiste (0,0) on origossa.");
		}
		else if (x > 0 && y > 0)
		{
			Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 1.");
		}
		else if (x < 0 && y > 0)
		{
			Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 2.");
		}
		else if (x < 0 && y < 0)
		{
			Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 3.");
		}
		else if (x > 0 && y < 0)
		{
			Console.WriteLine("Koordinaattipiste (" + x + "," + y + ") on kvadrantissa 4.");
		}
		else
		{
			Console.WriteLine("Höpö");
		}
	}
}
