using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_manager.Shared.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<Employee> Employees { get; set; }
    }
}
