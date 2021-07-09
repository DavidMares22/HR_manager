using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_manager.Shared.DTOs
{
    public class UserInfo
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public List<string> Roles { get; set; }

    }
}
