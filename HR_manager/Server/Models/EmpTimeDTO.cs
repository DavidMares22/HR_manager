using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Models
{
    public class EmpTimeDTO
    {
        public int Id { get; set; }

        [Required]
        public string FK_EmployeeTime_to_Employee { get; set; }

        [Required]
        public int FK_EmployeeTime_to_LoggedTime { get; set; }
    }
}
