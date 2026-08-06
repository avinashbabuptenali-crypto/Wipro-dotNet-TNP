using System;

class Employee
{
    string empName;
    decimal basicSalary, hra, da, tax, grossPay, netPay;

    public Employee(string name, decimal basic)
    {
        empName = name;
        basicSalary = basic;
    }

    public void CalculateNetPay()
    {
        hra = basicSalary * 15 / 100;
        da = basicSalary * 10 / 100;
        grossPay = basicSalary + hra + da;
        tax = grossPay * 8 / 100;
        netPay = grossPay - tax;
    }

    public void Display()
    {
        Console.WriteLine("Employee Name : " + empName);
        Console.WriteLine("Basic Salary  : " + basicSalary);
        Console.WriteLine("HRA           : " + hra);
        Console.WriteLine("DA            : " + da);
        Console.WriteLine("Gross Pay     : " + grossPay);
        Console.WriteLine("Tax           : " + tax);
        Console.WriteLine("Net Pay       : " + netPay);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        decimal basic = Convert.ToDecimal(Console.ReadLine());

        Employee emp = new Employee(name, basic);
        emp.CalculateNetPay();
        emp.Display();
    }
}