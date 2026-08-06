using System;

class RandomHelper
{
    // Create a single Random object
    static Random random = new Random();

    // Static method to generate a random integer (inclusive)
    public static int randint(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    // Static method to generate a random double
    public static double randdouble(int min, int max)
    {
        return min + random.NextDouble() * (max - min);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the minimum value: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the maximum value: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int randomInt = RandomHelper.randint(min, max);
        double randomDouble = RandomHelper.randdouble(min, max);

        Console.WriteLine("\nRandom Integer = " + randomInt);
        Console.WriteLine("Random Double = " + randomDouble);
    }
}