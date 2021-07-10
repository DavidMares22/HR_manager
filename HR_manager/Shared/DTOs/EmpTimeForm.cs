using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_manager.Shared.DTOs
{
    public class EmpTimeForm
    {
        [Required]
        [Range(typeof(DateTime), "2021-06-01", "2021-06-30")]
        public DateTime DateLogged { get; set; }

        [Required]
        [Range(1, 12)]
        public Double Hours { get; set; }
    }
}
