using System;

class MathOperations
{
    
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }

    
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    
    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Divide(int a, int b, int c)
    {
        return (a / b) / c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOperations obj = new MathOperations();

        Console.WriteLine("Addition");
        Console.WriteLine("10 + 20 = " + obj.Add(10, 20));
        Console.WriteLine("10 + 20 + 30 = " + obj.Add(10, 20, 30));

        Console.WriteLine();

        Console.WriteLine("Subtraction");
        Console.WriteLine("20 - 10 = " + obj.Subtract(20, 10));
        Console.WriteLine("50 - 20 - 10 = " + obj.Subtract(50, 20, 10));

        Console.WriteLine();

        Console.WriteLine("Multiplication");
        Console.WriteLine("10 * 20 = " + obj.Multiply(10, 20));
        Console.WriteLine("2 * 3 * 4 = " + obj.Multiply(2, 3, 4));

        Console.WriteLine();

        Console.WriteLine("Division");
        Console.WriteLine("20 / 5 = " + obj.Divide(20, 5));
        Console.WriteLine("100 / 5 / 2 = " + obj.Divide(100, 5, 2));
    }
}