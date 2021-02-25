using System;

class joo
{
	static void Main(String[] args)
	{
		int i, x;
		string tulostus = "";
		
		x = int.Parse(args[0]);
		
		for (i = 1; i <= x; i++)
		{
			tulostus = tulostus + i;
			Console.Write(tulostus + "\n\r");
		}
	}
}
