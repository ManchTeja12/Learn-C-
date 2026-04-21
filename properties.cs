using System;

public class employee
{
    private string name;
    private int id;
    private double salary;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public int Id
    {
        get { return id;}
        set { id = value; }
    }
}
class print
{
    public static void example()
    {
        employee em = new employee();
        em.Name = "Tejaswi";
        em.Id = 12;
        em.Salary = 50000;
        Console.WriteLine(em.Name);
        Console.WriteLine(em.Id);
        Console.WriteLine(em.Salary);
    }
}

