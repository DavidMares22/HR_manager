using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Models
{
    public class EmpDataDTO
    {
        [Required]
        public float HourlyRate { get; set; }

        [Required]
        public string FK_EmployeeData_To_Employee { get; set; }
        
        [Required]
        public int FK_EmployeeData_To_EmployeeType { get; set; }

        public int FK_EmployeeData_To_Department { get; set; }
    }
}
