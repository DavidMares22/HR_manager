using HR_manager.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Client.Repository
{
    public interface IEmployeeRepository
    {
        Task CreateEmployee(EmployeeType employee);
        Task<EmployeeType> GetEmployee(int Id);
        Task UpdateEmployee(EmployeeType employee, int Id);
    }
}
