using System;

public class School
{
	public int Id;
	public string Name;

	public School(int id,string name)
	{
		this.Id = id;
		this.Name = name;
	}
	public void display()
	{
		Console.WriteLine($"{Name}-{Id}");
	}
}
public class Program
{
	public static void con()
	{
		School s = new School(1,"Teju");
		s.display();

	}
}
