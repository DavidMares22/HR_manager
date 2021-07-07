using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_manager.Shared.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MiddleName { get; set; }
        public double LastName { get; set; }

        [ForeignKey(nameof(Department))]
        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
