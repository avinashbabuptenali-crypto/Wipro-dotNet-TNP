using System;
using System.Collections;

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
    SortedList employees = new SortedList();

    public bool AddEmployee(Employee e)
    {
        if (employees.ContainsKey(e.EmployeeID))
            return false;

        employees.Add(e.EmployeeID, e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        if (employees.ContainsKey(id))
        {
            employees.Remove(id);
            return true;
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        if (employees.ContainsKey(id))
        {
            Employee e = (Employee)employees[id];
            return e.EmployeeName;
        }
        return null;
    }

    public Employee[] GetAllEmployeesList()
    {
        Employee[] emp = new Employee[employees.Count];

        for (int i = 0; i < employees.Count; i++)
        {
            emp[i] = (Employee)employees.GetByIndex(i);
        }

        return emp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeDAL obj = new EmployeeDAL();

        obj.AddEmployee(new Employee(103, "Rahul", 45000));
        obj.AddEmployee(new Employee(101, "Avinash", 50000));
        obj.AddEmployee(new Employee(102, "Anil", 60000));

        Console.WriteLine("Employee List");
        Console.WriteLine("--------------------------");

        Employee[] list = obj.GetAllEmployeesList();

        foreach (Employee e in list)
        {
            Console.WriteLine("ID : " + e.EmployeeID);
            Console.WriteLine("Name : " + e.EmployeeName);
            Console.WriteLine("Salary : " + e.Salary);
            Console.WriteLine();
        }

        Console.WriteLine("Searching Employee with ID 102");
        string name = obj.SearchEmployee(102);

        if (name != null)
            Console.WriteLine("Employee Found : " + name);
        else
            Console.WriteLine("Employee Not Found");

        Console.WriteLine();

        Console.WriteLine("Deleting Employee with ID 101");

        if (obj.DeleteEmployee(101))
            Console.WriteLine("Employee Deleted Successfully");
        else
            Console.WriteLine("Employee Not Found");

        Console.WriteLine();

        Console.WriteLine("Updated Employee List");
        Console.WriteLine("--------------------------");

        list = obj.GetAllEmployeesList();

        foreach (Employee e in list)
        {
            Console.WriteLine("ID : " + e.EmployeeID);
            Console.WriteLine("Name : " + e.EmployeeName);
            Console.WriteLine("Salary : " + e.Salary);
            Console.WriteLine();
        }
    }
}