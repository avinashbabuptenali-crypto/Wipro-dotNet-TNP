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

    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Aries";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Taurus";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Gemini";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cancer";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Leo";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Virgo";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Libra";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Scorpio";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Sagittarius";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Capricorn";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Aquarius";
            else
                return "Pisces";
        }
    }

    public bool IsBirthDay
    {
        get
        {
            return DateTime.Now.Day == dateOfBirth.Day &&
                   DateTime.Now.Month == dateOfBirth.Month;
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
    public double TotalPay { get; set; }
    public double NetPay { get; set; }

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
        TotalPay = Salary + HRA + DA;
        NetPay = TotalPay - Tax;
        return NetPay;
    }
}

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee h = new HourlyEmployee(
            "John",
            "Doe",
            "john@gmail.com",
            new DateTime(2002, 5, 20),
            40,
            500);

        PermanentEmployee p = new PermanentEmployee(
            "Alice",
            "Smith",
            "alice@gmail.com",
            new DateTime(2000, 8, 10),
            50000,
            10000,
            5000,
            4000);

        Console.WriteLine("===== Hourly Employee =====");
        Console.WriteLine("Name        : " + h.FullName);
        Console.WriteLine("Pay         : " + h.CalculatePay());
        Console.WriteLine("Is Adult    : " + h.IsAdult);
        Console.WriteLine("Sun Sign    : " + h.SunSign);
        Console.WriteLine("Birthday    : " + h.IsBirthDay);
        Console.WriteLine("Screen Name : " + h.ScreenName);

        Console.WriteLine();

        Console.WriteLine("===== Permanent Employee =====");
        Console.WriteLine("Name        : " + p.FullName);
        Console.WriteLine("Total Pay   : " + (p.Salary + p.HRA + p.DA));
        Console.WriteLine("Net Pay     : " + p.CalculatePay());
        Console.WriteLine("Is Adult    : " + p.IsAdult);
        Console.WriteLine("Sun Sign    : " + p.SunSign);
        Console.WriteLine("Birthday    : " + p.IsBirthDay);
        Console.WriteLine("Screen Name : " + p.ScreenName);
    }
}
