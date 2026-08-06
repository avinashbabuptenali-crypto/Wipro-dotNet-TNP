using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dob;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine()!;

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine()!;

            Console.Write("Enter Email: ");
            string email = Console.ReadLine()!;

            Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Person p = new Person(firstName, lastName, email, dob);

            Console.WriteLine("\nPerson Details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Name : " + p.FirstName + " " + p.LastName);
            Console.WriteLine("Email : " + p.Email);
            Console.WriteLine("DOB : " + p.DateOfBirth.ToShortDateString());
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException : Invalid Date Format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("OverflowException : Date value is out of range.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception : " + ex.Message);
        }
    }
}