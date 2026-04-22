using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Java;
using System.Security.Cryptography.X509Certificates;

public class Student : IComparable<Student>
{
    public int Mark;
    public string Name;
    public string Department;

    //icomparable implementation
    public int CompareTo(Student other)
    {
        return this.Mark.CompareTo(other.Mark);
    }
}

public class Linq
{
    public static void grade()
    {
        //List<Student> students = new List<Student>();

        //Console.Write("Enter number of students: ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine("Enter name:");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Enter mark:");
        //    int mark = int.Parse(Console.ReadLine());
        var students = new List<Student>()
        {
            new Student() { Name = "Teju", Mark = 90, Department = "CSE" },
            new Student() { Name = "Greeshma", Mark = 80, Department = "EEE" },
            new Student() { Name = "Ayisha", Mark = 85, Department = "CSE" },
            new Student() { Name = "Anu", Mark = 85, Department = "ECE" },
            new Student() { Name = "Varshini", Mark = 76, Department = "ECE" },

        }
        ;
        var groupstudents = students.Select(s => new
        {
            s.Name,
            s.Mark,
            s.Department,
            Grade = s.Mark >= 90 ? "A" :
                         s.Mark >= 80 ? "B" :
                         s.Mark >= 70 ? "C" :
                         s.Mark > 60 ? "D" : "Fail"
        }).OrderBy(s => s.Grade);
        //foreach (var group in groupstudents) if you want to group by garde use GroupBy
        //{
        //    Console.WriteLine($"\n Grade{group.Key}");
            foreach (var s in groupstudents)
            {
                Console.WriteLine($"{s.Name}-{s.Mark}-{s.Grade}");
            }

        var groupbydep = students.GroupBy(s => s.Department);
        foreach (var group in groupbydep)
        {
            Console.WriteLine($"\nDepartment{group.Key}");
            foreach (var s in group)
            {
                Console.WriteLine($"{s.Name}-{s.Mark}");
            }
        }
 
        var top3students = students.OrderByDescending(s => s.Mark).Take(3);
        Console.WriteLine("\ntop 3 grades");
        foreach(var s in top3students)
        {
            Console.WriteLine($"{s.Name}-{s.Mark}-{s.Department}");
        }

        //firstordefault    
        var first = students.Where(s => s.Department == "CSE").FirstOrDefault();
        if(first!=null)
        {
            Console.WriteLine($"{first.Department}");
        }

        //icomparable
        Console.WriteLine("\n students sorted by marks");
        students.Sort();
        foreach (var item in students) 
        {
            Console.WriteLine($"{item.Name}-{item.Mark}");
        }


    }
}
