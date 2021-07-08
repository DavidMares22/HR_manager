using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Data
{
    public class EmployeeData
    {
        public int Id { get; set; }

        public Double HourlyRate { get; set; }

        

        [ForeignKey("FK_EmployeeData_To_Employee")]
        public virtual Employee Employee { get; set; }


      

        [ForeignKey("FK_EmployeeData_To_EmployeeType")]
        public virtual EmployeeType EmployeeType { get; set; }

 

        [ForeignKey("FK_EmployeeData_To_Department")]
        public virtual Department Department { get; set; }

        
    }
}
