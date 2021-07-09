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
        [StringLength(maximumLength: 50, ErrorMessage = " Name Is Too Long")]
        public string Name { get; set; }

 
        public string UserId { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Middle Name Is Too Long")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Last Name Is Too Long")]
        public string LastName { get; set; }


    }
    public class EmployeeDTO: CreateEmployeeDTO
    {
        public int Id { get; set; }
    }
}
