using System;

class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }

    public string FullName
    {
        get { return firstName + " " + lastName; }
    }

    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;
            return age >= 18;
        }
    }

    public string ScreenName
    {
        get
        {
            return firstName.ToLower() + lastName.ToLower() +
                   dateOfBirth.ToString("MMdd");
        }
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName,
        string emailAddress, DateTime dateOfBirth, double salary)
        : base(firstName, lastName, emailAddress, dateOfBirth)
    {
        Salary = salary;
    }
}

interface IPayable
{
    double CalculatePay();
}

class HourlyEmployee : Employee, IPayable
{
    public double HoursWorked { get; set; }
    public double PayPerHour { get; set; }

    public HourlyEmployee(string firstName, string lastName,
        string emailAddress, DateTime dateOfBirth,
        double hoursWorked, double payPerHour)
        : base(firstName, lastName, emailAddress, dateOfBirth, 0)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public double CalculatePay()
    {
        Salary = HoursWorked * PayPerHour;
        return Salary;
    }
}

class PermanentEmployee : Employee, IPayable
{
    public double HRA { get; set; }
    public double DA { get; set; }
    public double Tax { get; set; }

    public PermanentEmployee(string firstName, string lastName,
        string emailAddress, DateTime dateOfBirth,
        double salary, double hra, double da, double tax)
        : base(firstName, lastName, emailAddress, dateOfBirth, salary)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
    }

    public double CalculatePay()
    {
        double totalPay = Salary + HRA + DA;
        double netPay = totalPay - Tax;
        return netPay;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPayable emp1 = new HourlyEmployee(
            "John",
            "Doe",
            "john@gmail.com",
            new DateTime(2002, 5, 20),
            40,
            500);

        IPayable emp2 = new PermanentEmployee(
            "Alice",
            "Smith",
            "alice@gmail.com",
            new DateTime(2000, 8, 10),
            50000,
            10000,
            5000,
            4000);

        Console.WriteLine("Hourly Employee Pay : " + emp1.CalculatePay());
        Console.WriteLine("Permanent Employee Pay : " + emp2.CalculatePay());
    }
}