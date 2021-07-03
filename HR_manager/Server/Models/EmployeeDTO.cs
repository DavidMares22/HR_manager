using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Models
{
    public class CreateEmployeeDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Employee Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Address Name Is Too Long")]
        public string MiddleName { get; set; }

        [Required]
        public int DepartmentId { get; set; }
    }
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public DepartmentDTO Department { get; set; }
    }
}
