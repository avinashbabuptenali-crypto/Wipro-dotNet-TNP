using System;

class Program
{
    static void Main()
    {
        int num1, num2, temp;

        Console.Write("Enter num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        
        num2 = ++num1;
        Console.WriteLine("\nAfter Pre-Increment:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

               Console.Write("\nEnter num1 again: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2 again: ");
        num2 = Convert.ToInt32(Console.ReadLine());

       
        num2 = num1++;
        Console.WriteLine("\nAfter Post-Increment:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        
        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
    }
}