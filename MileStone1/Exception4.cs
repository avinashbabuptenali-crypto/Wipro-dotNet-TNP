using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(firstName))
                throw new Exception("First Name cannot be empty.");

            foreach (char ch in firstName)
            {
                if (!char.IsLetter(ch))
                    throw new Exception("First Name should contain only alphabets.");
            }

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(lastName))
                throw new Exception("Last Name cannot be empty.");

            foreach (char ch in lastName)
            {
                if (!char.IsLetter(ch))
                    throw new Exception("Last Name should contain only alphabets.");
            }

            Console.WriteLine("\nDetails Accepted Successfully");
            Console.WriteLine("Name : " + firstName + " " + lastName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}