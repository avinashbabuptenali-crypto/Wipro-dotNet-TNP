using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (single digit): ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 10 == num2)
            Console.WriteLine(num2 + " is in the Unit's place.");
        else if ((num1 / 10) % 10 == num2)
            Console.WriteLine(num2 + " is in the Ten's place.");
        else if ((num1 / 100) % 10 == num2)
            Console.WriteLine(num2 + " is in the Hundred's place.");
        else if ((num1 / 1000) % 10 == num2)
            Console.WriteLine(num2 + " is in the Thousand's place.");
        else
            Console.WriteLine(num2 + " is not present in Unit's, Ten's, Hundred's, or Thousand's place.");
    }
}