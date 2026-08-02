using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public decimal Salary { get; set; }

        [Required]
        public DateTime DateOfJoining { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public string Designation { get; set; }

        public string EmploymentStatus { get; set; } = "Active";
    }
}