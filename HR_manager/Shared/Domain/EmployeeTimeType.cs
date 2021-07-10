using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_manager.Shared.Domain
{
    public class EmployeeTimeType
    {
        public string FK_EmployeeTime_to_Employee { get; set; }

        public int FK_EmployeeTime_to_LoggedTime { get; set; }
    }
}
