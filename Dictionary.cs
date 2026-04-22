using System;
using System.Collections.Generic;
public class Dict
{
	 public static void dictionary()
	{
		Dictionary<int, String> students = new Dictionary<int, string>();
		int n = int.Parse(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("Enter Student Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name ");
            String name=Console.ReadLine();
            students[id] = name;
        }
        Console.WriteLine("Student Details:");
        foreach(var item in students)
        {
            Console.WriteLine($"Student id:{item.Key},Student Name:{item.Value}");
        }
        Linq.grade();
        
     
    }
}
