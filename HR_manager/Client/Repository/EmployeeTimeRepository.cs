using HR_manager.Client.Helper;
using HR_manager.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Client.Repository
{
    public class EmployeeTimeRepository:IEmployeeTimeRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/EmployeeTime";
        public EmployeeTimeRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }



        public async Task<int> CreateEmployeeTime(EmployeeTimeType empTime)
        {
            var response = await httpService.Post(url, empTime);
            if (!response.Success)
            {
                Console.WriteLine("error creating loggedTime");
                return 0;
            }
            else
            {


                return 1;
            }


        }


    }
}
