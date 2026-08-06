using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a String: ");
        string str = Console.ReadLine();

        List<char> AlphaList = new List<char>();
        List<int> DigitList = new List<int>();

        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                AlphaList.Add(ch);
            }
            else if (char.IsDigit(ch))
            {
                DigitList.Add(ch - '0');
            }
        }

        AlphaList.Sort();
        DigitList.Sort();

        Console.WriteLine("\nAlphabets");

        foreach (char c in AlphaList)
        {
            Console.Write(c + " ");
        }

        Console.WriteLine("\n\nDigits");

        foreach (int n in DigitList)
        {
            Console.Write(n + " ");
        }
    }
}