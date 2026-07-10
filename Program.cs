using System;
using System.Collections.Generic;

abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int LeaveBalance { get; set; }

    public abstract void SetLeaveBalance();

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Department: {Department}, Leave Balance: {LeaveBalance}");
    }
}

class PermanentEmployee : Employee
{
    public override void SetLeaveBalance()
    {
        LeaveBalance = 24;
    }
}

class ContractEmployee : Employee
{
    public override void SetLeaveBalance()
    {
        LeaveBalance = 12;
    }
}

class LeaveRequest
{
    public int LeaveId { get; set; }
    public int EmployeeId { get; set; }
    public int NumberOfDays { get; set; }
    public string Reason { get; set; }

    public void DisplayLeave()
    {
        Console.WriteLine($"Leave ID: {LeaveId}, Employee ID: {EmployeeId}, Days: {NumberOfDays}, Reason: {Reason}");
    }
}

class Program
{
    static void Main()
    {
        // Task 1
        List<Employee> employees = new List<Employee>();

        PermanentEmployee emp1 = new PermanentEmployee
        {
            EmployeeId = 101,
            Name = "Achal",
            Department = "IT"
        };
        emp1.SetLeaveBalance();

        ContractEmployee emp2 = new ContractEmployee
        {
            EmployeeId = 102,
            Name = "Rahul",
            Department = "HR"
        };
        emp2.SetLeaveBalance();

        PermanentEmployee emp3 = new PermanentEmployee
        {
            EmployeeId = 103,
            Name = "Priya",
            Department = "Finance"
        };
        emp3.SetLeaveBalance();

        employees.Add(emp1);
        employees.Add(emp2);
        employees.Add(emp3);

        // Task 2
        Console.WriteLine("All Employees:");
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        // Task 3
        List<LeaveRequest> leaveRequests = new List<LeaveRequest>()
        {
            new LeaveRequest
            {
                LeaveId = 1,
                EmployeeId = 101,
                NumberOfDays = 2,
                Reason = "Personal Work"
            },
            new LeaveRequest
            {
                LeaveId = 2,
                EmployeeId = 103,
                NumberOfDays = 3,
                Reason = "Medical Leave"
            }
        };

        // Task 4
        Console.WriteLine("\nAll Leave Requests:");
        foreach (LeaveRequest leave in leaveRequests)
        {
            leave.DisplayLeave();
        }

        // Task 5
        Console.WriteLine("\nPermanent Employees:");
        foreach (Employee emp in employees)
        {
            if (emp is PermanentEmployee)
            {
                emp.DisplayDetails();
            }
        }

        // Task 6
        Console.WriteLine("\nEmployee with ID 103:");
        Employee foundEmployee = employees.Find(e => e.EmployeeId == 103);

        if (foundEmployee != null)
        {
            foundEmployee.DisplayDetails();
        }

        // Task 7
        Console.WriteLine($"\nTotal Employees: {employees.Count}");

        // Task 8
        Console.WriteLine($"Total Leave Requests: {leaveRequests.Count}");
    }
}