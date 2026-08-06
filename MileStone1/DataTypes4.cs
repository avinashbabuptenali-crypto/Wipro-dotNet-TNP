using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        
        Console.WriteLine("\n1. String in Reverse Order:");
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }

               Console.WriteLine("\n\n2. Substring from 2nd Position:");
        Console.WriteLine(str.Substring(1));

                Console.Write("\nEnter the character to replace: ");
        char ch = Convert.ToChar(Console.ReadLine());

        string newString = str.Replace(ch, '$');

        Console.WriteLine("3. New String after Replacement:");
        Console.WriteLine(newString);
        string str2 = str;

        str2 = str2 + " Welcome";

        Console.WriteLine("\n4. Original String: " + str);
        Console.WriteLine("Modified Copied String: " + str2);
    }
}