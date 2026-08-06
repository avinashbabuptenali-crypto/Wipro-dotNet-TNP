using System;


class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks in Subject 1: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());

            if (mark1 < 0)
                throw new NegativeNumberException("Marks cannot be negative.");

            Console.Write("Enter Marks in Subject 2: ");
            int mark2 = Convert.ToInt32(Console.ReadLine());

            if (mark2 < 0)
                throw new NegativeNumberException("Marks cannot be negative.");

            Console.Write("Enter Marks in Subject 3: ");
            int mark3 = Convert.ToInt32(Console.ReadLine());

            if (mark3 < 0)
                throw new NegativeNumberException("Marks cannot be negative.");

            double average = (mark1 + mark2 + mark3) / 3.0;

            Console.WriteLine("\nStudent Details");
            Console.WriteLine("----------------------");
            Console.WriteLine("Name    : " + name);
            Console.WriteLine("Mark 1  : " + mark1);
            Console.WriteLine("Mark 2  : " + mark2);
            Console.WriteLine("Mark 3  : " + mark3);
            Console.WriteLine("Average : " + average);
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException: Please enter only integer values for marks.");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("NegativeNumberException: " + ex.Message);
        }
    }
}