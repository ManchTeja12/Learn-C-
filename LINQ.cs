using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Mark;
    public string Name;
}

public class linq
{
    public static void grade()
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter mark:");
            int mark = int.Parse(Console.ReadLine());

            students.Add(new Student { Name = name, Mark = mark });
        }

        var result = students.Where(s => s.Mark > 80);//linq

        Console.WriteLine("\nStudents with Mark > 80:");
        foreach (var s in result)
        {
            Console.WriteLine(s.Name);
        }
    }
}