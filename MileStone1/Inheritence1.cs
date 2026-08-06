using System;

class Person
{
    private string FirstName;
    private string LastName;
    private string EmailAddress;
    private DateTime DateOfBirth;

    public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = email;
        DateOfBirth = dateOfBirth;
    }

    public bool IsAdult
    {
        get
        {
            int age = DateTime.Today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > DateTime.Today.AddYears(-age))
                age--;

            return age >= 18;
        }
    }

    public string SunSign
    {
        get
        {
            int day = DateOfBirth.Day;
            int month = DateOfBirth.Month;

            switch (month)
            {
                case 1: return (day <= 19) ? "Capricorn" : "Aquarius";
                case 2: return (day <= 18) ? "Aquarius" : "Pisces";
                case 3: return (day <= 20) ? "Pisces" : "Aries";
                case 4: return (day <= 19) ? "Aries" : "Taurus";
                case 5: return (day <= 20) ? "Taurus" : "Gemini";
                case 6: return (day <= 20) ? "Gemini" : "Cancer";
                case 7: return (day <= 22) ? "Cancer" : "Leo";
                case 8: return (day <= 22) ? "Leo" : "Virgo";
                case 9: return (day <= 22) ? "Virgo" : "Libra";
                case 10: return (day <= 22) ? "Libra" : "Scorpio";
                case 11: return (day <= 21) ? "Scorpio" : "Sagittarius";
                case 12: return (day <= 21) ? "Sagittarius" : "Capricorn";
                default: return "Unknown";
            }
        }
    }

    public bool IsBirthDay
    {
        get
        {
            return DateTime.Today.Month == DateOfBirth.Month &&
                   DateTime.Today.Day == DateOfBirth.Day;
        }
    }

    public string ScreenName
    {
        get
        {
            string first = FirstName.ToLower();
            string last = LastName.ToLower();

            return first + last +
                   DateOfBirth.ToString("MMddyy");
        }
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string email,
                    DateTime dateOfBirth, double salary)
        : base(firstName, lastName, email, dateOfBirth)
    {
        Salary = salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(
            "Hari",
            "Doe",
            "hari@example.com",
            new DateTime(2000, 5, 25),
            50000);

        Console.WriteLine("Employee Details");
        Console.WriteLine("----------------");
        Console.WriteLine("Salary      : " + emp.Salary);
        Console.WriteLine("Is Adult    : " + emp.IsAdult);
        Console.WriteLine("Sun Sign    : " + emp.SunSign);
        Console.WriteLine("Birthday    : " + emp.IsBirthDay);
        Console.WriteLine("Screen Name : " + emp.ScreenName);
    }
}
