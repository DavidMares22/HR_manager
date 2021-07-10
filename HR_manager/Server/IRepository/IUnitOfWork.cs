using HR_manager.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        
        IGenericRepository<EmployeeTime> EmployeeTime { get; }

        IGenericRepository<LoggedTime> LoggedTime { get; }
        IGenericRepository<EmployeeData> EmployeeData { get; }
        IGenericRepository<Employee> Employees { get; }
        IGenericRepository<Department> Departments { get; }
        Task Save();
    }
}
