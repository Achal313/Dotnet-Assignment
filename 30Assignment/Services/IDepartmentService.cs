using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        Department? GetById(int id);
        Department Add(Department department);
        bool Update(int id, Department department);
        bool Delete(int id);
    }
}
