using System;
public class test
{
	static public void Increment (ref int x)
	{
		x++;
	}
	static public void Ref()
	{
		int a = 0;
		Increment(ref a);
		Console.WriteLine(a);
		//Console.Clear();
	}
}
