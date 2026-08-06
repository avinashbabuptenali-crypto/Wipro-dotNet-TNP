using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "Student.txt";

        StreamWriter writer = new StreamWriter(path);

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Roll Number: ");
        string rollNo = Console.ReadLine()!;

        Console.Write("Enter Department: ");
        string department = Console.ReadLine()!;

        writer.WriteLine("Student Details");
        writer.WriteLine("----------------------");
        writer.WriteLine("Name : " + name);
        writer.WriteLine("Roll Number : " + rollNo);
        writer.WriteLine("Department : " + department);

        writer.Close();

        Console.WriteLine("\nFile created successfully.");
    }
}