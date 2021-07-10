
using HR_manager.Server.Data;
using HR_manager.Server.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DatabaseContext _context;
        private IGenericRepository<Employee> _employees;
        private IGenericRepository<Department> _departments;
        private IGenericRepository<EmployeeData> _empdata;
        private IGenericRepository<LoggedTime> _loggedtime;
        private IGenericRepository<EmployeeTime> _empTime;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Employee> Employees => _employees ??= new GenericRepository<Employee>(_context);

        public IGenericRepository<Department> Departments => _departments ??= new GenericRepository<Department>(_context);

        public IGenericRepository<EmployeeData> EmployeeData => _empdata ??= new GenericRepository<EmployeeData>(_context);

        public IGenericRepository<LoggedTime> LoggedTime => _loggedtime ??= new GenericRepository<LoggedTime>(_context);
        
        public IGenericRepository<EmployeeTime> EmployeeTime => _empTime ??= new GenericRepository<EmployeeTime>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
