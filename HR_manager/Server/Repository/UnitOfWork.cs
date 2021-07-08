
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

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Employee> Employees => _employees ??= new GenericRepository<Employee>(_context);

        public IGenericRepository<Department> Departments => _departments ??= new GenericRepository<Department>(_context);

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
