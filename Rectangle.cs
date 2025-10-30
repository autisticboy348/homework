using System;

public class Rectangle
{
    public double Width;
    public double Height;

    public double GetArea()
    {
        return (Width * Height);
    }
    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle();
        rect1.Width = 5.0;
        rect1.Height = 3.0;

        double area1 = rect1.GetArea();
        double perimeter1 = rect1.GetPerimeter();

        Rectangle rect2 = new Rectangle();
        rect2.Width = 7.5;
        rect2.Height = 4.2;

        double area2 = rect2.GetArea();
        double perimeter2 = rect2.GetPerimeter();

        Console.WriteLine("Rectangle 1:");
        Console.WriteLine($"Width:{rect1.Width}");
        Console.WriteLine($"Height:{rect1.Height}");
        Console.WriteLine($"Area:{area1}");
        Console.WriteLine($"Perimeter:{perimeter1}");
        Console.WriteLine();

        Console.WriteLine("Rectangle 2:");
        Console.WriteLine($"Width:{rect2.Width}");
        Console.WriteLine($"Height:{rect2.Height}");
        Console.WriteLine($"Area:{area2}");
        Console.WriteLine($"Perimeter:{perimeter2}");
        Console.WriteLine();

        Rectangle rect3 = new Rectangle();
        rect3.Width = 10.0;
        rect3.Height = 2.5;

        double area3 = rect3.GetArea();
        double perimeter3 = rect3.GetPerimeter();

        Console.WriteLine("Rectangle 3:");
        Console.WriteLine($"Width:{rect3.Width}");
        Console.WriteLine($"Height:{rect3.Height}");
        Console.WriteLine($"Area:{area3}");
        Console.WriteLine($"Perimeter:{perimeter3}");
        Console.WriteLine();
    }
}