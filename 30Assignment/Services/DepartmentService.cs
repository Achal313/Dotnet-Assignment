using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class DepartmentService : IDepartmentService
    {
        private static List<Department> departments = new()
        {
            new Department
            {
                Id = 1,
                DepartmentName = "IT",
                DepartmentCode = "IT01",
                Status = "Active"
            },
            new Department
            {
                Id = 2,
                DepartmentName = "HR",
                DepartmentCode = "HR01",
                Status = "Active"
            }
        };

        public List<Department> GetAll() => departments;

        public Department? GetById(int id)
        {
            return departments.FirstOrDefault(d => d.Id == id);
        }

        public Department Add(Department department)
        {
            department.Id = departments.Max(d => d.Id) + 1;
            departments.Add(department);
            return department;
        }

        public bool Update(int id, Department department)
        {
            var dept = GetById(id);

            if (dept == null)
                return false;

            dept.DepartmentName = department.DepartmentName;
            dept.DepartmentCode = department.DepartmentCode;
            dept.Status = department.Status;

            return true;
        }

        public bool Delete(int id)
        {
            var dept = GetById(id);

            if (dept == null)
                return false;

            departments.Remove(dept);
            return true;
        }
    }
}