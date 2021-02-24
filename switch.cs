using System;

class Juoma
{
	static void Main()
	{
		int valinta;
		
		Console.WriteLine("Valitse:\n1) Vesi\n2) Mehu\n3) Limonadi\n4) Lopeta");
		valinta = Convert.ToInt32(Console.ReadLine());
		
		switch (valinta)
		{
			case 1:
				Console.WriteLine("Valitsit Vesi.");
				break;
			case 2:
				Console.WriteLine("Valitsit Mehu.");
				break;
			case 3:
				Console.WriteLine("Valitsit Limonadi.");
				break;
			case 4:
				Console.WriteLine("Lopetus!");
				break;
			default:
				Console.WriteLine("Ei noin");
				break;
		}
	}
}
