using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = "";

        foreach (char ch in str)
        {
            char newChar = (char)(ch + 1);

            if (char.IsUpper(newChar))
            {
                newChar = char.ToLower(newChar);
            }
            else if (char.IsLower(newChar))
            {
                newChar = char.ToUpper(newChar);
            }

            result += newChar;
        }

        Console.WriteLine("New string: " + result);
    }
}