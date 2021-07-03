using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Models
{
    public class CreateDepartmentDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Department Name Is Too Long")]
        public string Name { get; set; }
         
    }
    public class DepartmentDTO: CreateDepartmentDTO
    {
        public int Id { get; set; }
        public IList<EmployeeDTO> Employees { get; set; }
    }
}
