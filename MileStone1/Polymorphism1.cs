using System;

class Area
{
    
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }

    
    public double CalculateArea(double length, double breadth)
    {
        return length * breadth;
    }

    
    public double CalculateArea(int baseValue, int height)
    {
        return 0.5 * baseValue * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Area obj = new Area();

        Console.Write("Enter radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter length of rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth of rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter base of triangle: ");
        int baseValue = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of triangle: ");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nArea of Circle = " + obj.CalculateArea(radius));
        Console.WriteLine("Area of Rectangle = " + obj.CalculateArea(length, breadth));
        Console.WriteLine("Area of Triangle = " + obj.CalculateArea(baseValue, height));
    }
}