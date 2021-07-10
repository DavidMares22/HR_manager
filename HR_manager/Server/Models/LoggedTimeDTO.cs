using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Models
{
    public class LoggedTimeDTO
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateLogged { get; set; }
        [Required]
        [Range(0, 12)]
        public Double Hours { get; set; }

        [Required]
        public int FK_LoggedTime_To_LoggedTimeType { get; set; }
    }
}
