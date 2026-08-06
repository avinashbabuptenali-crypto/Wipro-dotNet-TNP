using System;

class Person
{
    private string FirstName;
    private string LastName;
    private string EmailAddress;
    private DateTime DateofBirth;

    public Person(string firstName, string lastName, string email, DateTime dateofBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = email;
        DateofBirth = dateofBirth;
    }

    public bool IsAdult
    {
        get
        {
            return DateTime.Today.AddYears(-18) >= DateofBirth;
        }
    }

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    public string Email
    {
        get
        {
            return EmailAddress;
        }
    }
}


class HourlyEmployee : Person
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(
        string firstName,
        string lastName,
        string email,
        DateTime dateofBirth,
        double hoursWorked,
        double payPerHour)
        : base(firstName, lastName, email, dateofBirth)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double TotalPay
    {
        get
        {
            return HoursWorked * PayPerHour;
        }
    }
}


class PermanentEmployee : Person
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }
    public double TotalPay { get; set; }
    public double NetPay { get; set; }

    public PermanentEmployee(
        string firstName,
        string lastName,
        string email,
        DateTime dateofBirth,
        double hra,
        double da,
        double tax,
        double totalPay)
        : base(firstName, lastName, email, dateofBirth)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
        TotalPay = totalPay;

        NetPay = TotalPay + HRA + DA - Tax;
    }
}


class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hourlyEmployee = new HourlyEmployee(
            "Avinash",
            "P",
            "avinash@gmail.com",
            new DateTime(2003, 5, 10),
            40,
            500
        );

        Console.WriteLine("HOURLY EMPLOYEE");
        Console.WriteLine("Name: " + hourlyEmployee.FullName);
        Console.WriteLine("Email: " + hourlyEmployee.Email);
        Console.WriteLine("Is Adult: " + hourlyEmployee.IsAdult);
        Console.WriteLine("Hours Worked: " + hourlyEmployee.HoursWorked);
        Console.WriteLine("Pay Per Hour: " + hourlyEmployee.PayPerHour);
        Console.WriteLine("Total Pay: " + hourlyEmployee.TotalPay);


        Console.WriteLine("\n--------------------------\n");


        PermanentEmployee permanentEmployee = new PermanentEmployee(
            "Rahul",
            "Kumar",
            "rahul@gmail.com",
            new DateTime(2000, 8, 15),
            5000,
            3000,
            2000,
            30000
        );

        Console.WriteLine("PERMANENT EMPLOYEE");
        Console.WriteLine("Name: " + permanentEmployee.FullName);
        Console.WriteLine("Email: " + permanentEmployee.Email);
        Console.WriteLine("Is Adult: " + permanentEmployee.IsAdult);
        Console.WriteLine("HRA: " + permanentEmployee.HRA);
        Console.WriteLine("DA: " + permanentEmployee.DA);
        Console.WriteLine("Tax: " + permanentEmployee.Tax);
        Console.WriteLine("Total Pay: " + permanentEmployee.TotalPay);
        Console.WriteLine("Net Pay: " + permanentEmployee.NetPay);
    }
}