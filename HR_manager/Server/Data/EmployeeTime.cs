using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Data
{
    public class EmployeeTime
    {
        public int Id { get; set; }

        [ForeignKey("FK_EmployeeTime_to_Employee")]
        public string FK_EmployeeTime_to_Employee { get; set; }

        [ForeignKey("FK_EmployeeTime_to_LoggedTime")]
        public int FK_EmployeeTime_to_LoggedTime { get; set; }

    }
}
