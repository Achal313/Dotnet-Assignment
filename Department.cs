using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "DepartName is Required")]
        [MaxLength(50)]
        public string DepartmentName { get; set; }

        public string? DepartmentCode { get; set; }

        [Required]
        public string Status { get; set; } = "Active";
    }
}