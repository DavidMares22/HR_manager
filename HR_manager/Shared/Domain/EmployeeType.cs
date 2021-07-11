using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_manager.Shared.Domain
{

    public class EmployeeList
    {
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
    public class EmployeeType:EmployeeList
    {
        public int Id { get; set; }

       
    }
}
