using System;

public class Tasks
{
    public static void Main(string[] args)
    {
        int myAge = 20;
        double bankBalance = new Random().NextDouble() * 10000;

        if (bankBalance >= 1000)
        {
            Console.WriteLine("I have a healthy bank balance!");
        }
        else
        {
            Console.WriteLine("I need to save more.");
        }

        Shape rectangle = new Rectangle(80, 40);
        Shape circle = new Circle(15);

        Console.WriteLine($"Rectangle area: {rectangle.Area}");
        Console.WriteLine($"Circle area: {circle.Area}");

        Person person = new Person(20, "Levan Zrnadze");
        person.PrintDetails();
    }
}

public class Shape
{
    protected double area;

    public double Area
    {
        get { return area; }
        internal set { area = value; }
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public double Length
    {
        get { return length; }
        set { length = value; Area = length * width; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; Area = length * width; }
    }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
}

public class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; Area = Math.PI * radius * radius; }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
}

public class Person
{
    private int age;
    public string Name { get; set; }

    public Person(int age, string name)
    {
        this.age = age;
        this.Name = name;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {age}");
    }
}




