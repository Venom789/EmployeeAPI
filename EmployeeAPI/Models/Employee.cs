using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? EmployeeName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string? Department { get; set; }

        [Required]
        [StringLength(20)]
        public string? Designation { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double BasicSalary { get; set; }


    }
}
