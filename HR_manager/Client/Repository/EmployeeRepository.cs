using HR_manager.Client.Helper;
using HR_manager.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Client.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/Employee";

        public EmployeeRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateEmployee(Employee employee)
        {
            var response = await httpService.Post(url, employee);
            if (!response.Success)
            {
                Console.WriteLine("error creating employee");
            }
        }
        public async Task<Employee> GetEmployee(int Id)
        {
            var response = await httpService.Get<Employee>($"{url}/{Id}");
            if (!response.Success)
            {
                Console.WriteLine("error creating employee");
            }
            return response.Response;
        }

        public async Task UpdateEmployee(Employee employee, int Id)
        {
            var response = await httpService.Put($"{url}/{Id}", employee);
            if (!response.Success)
            {
                Console.WriteLine("error updating employee");
            }
        }


    }
}
