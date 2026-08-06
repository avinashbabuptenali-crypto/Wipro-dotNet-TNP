using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        int sum = 0;

        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sort in Descending Order
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("\nElements in Descending Order:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }

        int max = arr[0];
        int min = arr[0];

        for (int i = 0; i < 10; i++)
        {
            if (arr[i] > max)
                max = arr[i];

            if (arr[i] < min)
                min = arr[i];

            sum += arr[i];
        }

        Console.WriteLine("\n\nMaximum Value = " + max);
        Console.WriteLine("Minimum Value = " + min);
        Console.WriteLine("Sum of Array Elements = " + sum);
    }
}