using System;

class Program
{
    static void Main(string[] args)
    {
        string studentName;
        int mark1, mark2, mark3;
        double average;

        try
        {
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Marks in Subject 1: ");
            mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks in Subject 2: ");
            mark2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks in Subject 3: ");
            mark3 = Convert.ToInt32(Console.ReadLine());

            average = (mark1 + mark2 + mark3) / 3.0;

            Console.WriteLine("\nStudent Name : " + studentName);
            Console.WriteLine("Subject 1 Marks : " + mark1);
            Console.WriteLine("Subject 2 Marks : " + mark2);
            Console.WriteLine("Subject 3 Marks : " + mark3);
            Console.WriteLine("Average Marks : " + average);
        }
        catch (FormatException)
        {
            Console.WriteLine("\nFormatException Caught!");
            Console.WriteLine("Please enter only integer values for marks.");
        }
    }
}