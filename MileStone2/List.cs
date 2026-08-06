using System;
using System.Collections.Generic;

class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        EmployeeID = id;
        EmployeeName = name;
        Salary = salary;
    }
}

class EmployeeDAL
{
    List<Employee> employees = new List<Employee>();

    public bool AddEmployee(Employee e)
    {
        employees.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        Employee emp = employees.Find(e => e.EmployeeID == id);

        if (emp != null)
        {
            employees.Remove(emp);
            return true;
        }

        return false;
    }

    public string SearchEmployee(int id)
    {
        Employee emp = employees.Find(e => e.EmployeeID == id);

        if (emp != null)
            return emp.EmployeeName;

        return null;
    }

    public List<Employee> GetAllEmployees()
    {
        return employees;
    }
}

class Program
{
    static void Main()
    {
        EmployeeDAL obj = new EmployeeDAL();

        obj.AddEmployee(new Employee(101, "Hasan", 50000));
        obj.AddEmployee(new Employee(102, "Rahul", 60000));

        Console.WriteLine(obj.SearchEmployee(101));

        foreach (Employee e in obj.GetAllEmployees())
        {
            Console.WriteLine(e.EmployeeID + " " + e.EmployeeName + " " + e.Salary);
        }
    }
}