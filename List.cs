using System;

public class list
{
	public static void array()
	{
		List<int> numbers = new List<int>();
		int n = int.Parse(Console.ReadLine());
		int sum = 0;
		for(int i=0;i<n;i++)
		{
			int value = int.Parse(Console.ReadLine());
			numbers.Add(value);
			sum = sum + i;
		}
		Console.WriteLine(sum);

	}
}
