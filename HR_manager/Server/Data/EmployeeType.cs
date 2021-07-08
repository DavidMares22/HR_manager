﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Data
{
    public class EmployeeType
    {
        public int Id { get; set; }
        
        [Required]
        public string Description { get; set; }
    }
}
