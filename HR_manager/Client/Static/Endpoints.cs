using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Client.Static
{
    public class Endpoints
    {
        public static string Prefix = "api";

        public static string EmployeesEndpoint = $"{Prefix}/Employee";
        public static string LoggedTimeEndpoint = $"{Prefix}/LoggedTime";
        public static string EmployeeTimeEndpoint = $"{Prefix}/EmployeeTime";
        

    }
}
