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
        //public ApiUser ApiUser { get; set; }
        public string FK_EmployeeData_To_Employee { get; set; }



        [ForeignKey("FK_EmployeeData_To_EmployeeType")]
        //public EmployeeType EmployeeType { get; set; }
        public int FK_EmployeeData_To_EmployeeType { get; set; }


        [ForeignKey("FK_EmployeeData_To_Department")]
        //public Department Department { get; set; }
        public int FK_EmployeeData_To_Department { get; set; }
 
        
    }
}
