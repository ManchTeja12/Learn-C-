using System;

interface Ishape
{
    double area();
    double perimeter();
    void display()
    {
        Console.WriteLine("This is a Default Method");
    }
    static void show()
    {
        Console.WriteLine("This is a Static Method");
    }
}
public class Circle :Ishape
{
    public double Radius;
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double area()
    {
        return  Math.PI * Radius * Radius;
    }
    public double perimeter()
    { 
        return 2 * Math.PI * Radius;
    }
    public void display()
    {
        Console.WriteLine("Hello");
    }

}
public class Rectangle : Ishape
{
    public int length, width;
    public Rectangle(int l,int w)
    {
        length = l;
        width = w;
    }
    public double area()
    {
        return length * width;
    }
    public double perimeter()
    {
        return 2 * (length + width);
    }
    public void display()
    {
        Console.WriteLine("hi");
    }
}
public class Input
{
    public static void main()
    {
        Ishape c = new Circle(5); // object is created for class using interface reference
        Ishape r = new Rectangle(2, 2);
        Console.WriteLine($"Circle Area:{c.area():F2}");
        Console.WriteLine($"Perimeer of Circle :{c.perimeter():F3}");
        Ishape.show();
        r.display();
    }
}

