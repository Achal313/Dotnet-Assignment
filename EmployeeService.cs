using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                EmployeeId = 1,
                FirstName = "Rahul",
                LastName = "Sharma",
                Email = "rahul@gmail.com",
                MobileNumber = "9876543210",
                DateOfBirth = new DateTime(2000,1,1),
                Gender = "Male",
                Salary = 50000,
                DateOfJoining = new DateTime(2024,1,1),
                DepartmentId = 1,
                Designation = "Developer",
                EmploymentStatus = "Active"
            }
        };

        public List<Employee> GetAll() => employees;

        public Employee? GetById(int id)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public Employee Add(Employee employee)
        {
            employee.EmployeeId = employees.Max(e => e.EmployeeId) + 1;
            employees.Add(employee);
            return employee;
        }

        public bool Update(int id, Employee employee)
        {
            var emp = GetById(id);

            if (emp == null)
                return false;

            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Email = employee.Email;
            emp.MobileNumber = employee.MobileNumber;
            emp.DateOfBirth = employee.DateOfBirth;
            emp.Gender = employee.Gender;
            emp.Salary = employee.Salary;
            emp.DateOfJoining = employee.DateOfJoining;
            emp.DepartmentId = employee.DepartmentId;
            emp.Designation = employee.Designation;
            emp.EmploymentStatus = employee.EmploymentStatus;

            return true;
        }

        public bool Delete(int id)
        {
            var emp = GetById(id);

            if (emp == null)
                return false;

            employees.Remove(emp);
            return true;
        }
    }
}