using HR_manager.Client.Helper;
using HR_manager.Shared.Domain;
using HR_manager.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Client.Repository
{
    public class LoggedTimeRepository:ILoggedTimeRepository
    {
    private readonly IHttpService httpService;
    private string url = "api/LoggedTime";
    public LoggedTimeRepository(IHttpService httpService)
    {
        this.httpService = httpService;
    }



        public async Task<int> CreateTimeLogged(LoggedTimeType loggedTime)
        {
            var response = await httpService.Post(url, loggedTime);
            if (!response.Success)
            {
                Console.WriteLine("error creating loggedTime");
                return 0;
            }
            else
            {

            ResponseTimeLog IdLog = await response.GetBodyTimeLog();
            return Int32.Parse(IdLog.Id);
            }

        }
    }
}
