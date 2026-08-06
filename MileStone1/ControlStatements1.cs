using System;

class Program
{
    static void Main()
    {
        string correctLogin = "admin";
        string correctPassword = "1234";

        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter Login: ");
            string login = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (login == correctLogin && password == correctPassword)
            {
                Console.WriteLine("Login Successful!");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid Login or Password.");

                if (attempts < 3)
                {
                    Console.WriteLine("Attempts Left: " + (3 - attempts));
                }
            }
        }

        Console.WriteLine("You have entered the wrong login/password 3 times.");
        Console.WriteLine("Access Denied!");
    }
}