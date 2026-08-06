using System;
using System.Collections;

class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeID = id;
        Salary = salary;
    }
}

class EmployeeDAL
{
    ArrayList employees = new ArrayList();

    // Add Employee
    public bool AddEmployee(Employee e)
    {
        employees.Add(e);
        return true;
    }

    // Delete Employee
    public bool DeleteEmployee(int id)
    {
        foreach (Employee e in employees)
        {
            if (e.EmployeeID == id)
            {
                employees.Remove(e);
                return true;
            }
        }
        return false;
    }

    // Search Employee
    public string SearchEmployee(int id)
    {
        foreach (Employee e in employees)
        {
            if (e.EmployeeID == id)
            {
                return e.EmployeeName;
            }
        }
        return null;
    }

    // Get All Employees
    public Employee[] GetAllEmployees()
    {
        Employee[] emp = new Employee[employees.Count];

        for (int i = 0; i < employees.Count; i++)
        {
            emp[i] = (Employee)employees[i];
        }

        return emp;
    }
}

class Program
{
    static void Main()
    {
        EmployeeDAL obj = new EmployeeDAL();

        obj.AddEmployee(new Employee("Hasan", 101, 50000));
        obj.AddEmployee(new Employee("Rahul", 102, 60000));
        obj.AddEmployee(new Employee("Amit", 103, 45000));

        Console.WriteLine("Employee Added Successfully\n");

        Console.WriteLine("Search Employee ID 102");
        Console.WriteLine(obj.SearchEmployee(102));

        Console.WriteLine();

        Console.WriteLine("Delete Employee ID 103");
        Console.WriteLine(obj.DeleteEmployee(103));

        Console.WriteLine();

        Console.WriteLine("Employee List");

        Employee[] list = obj.GetAllEmployees();

        foreach (Employee e in list)
        {
            Console.WriteLine("ID : " + e.EmployeeID);
            Console.WriteLine("Name : " + e.EmployeeName);
            Console.WriteLine("Salary : " + e.Salary);
            Console.WriteLine("-------------------------");
        }

        Console.ReadLine();
    }
}