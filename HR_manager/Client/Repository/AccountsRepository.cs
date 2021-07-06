using HR_manager.Client.Helper;
using HR_manager.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Client.Repository
{
    public class AccountsRepository : IAccountsRepository
    {

        private readonly IHttpService httpService;
        private readonly string baseURL = "api/Account";

        public AccountsRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }


        public async Task<string> Register(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, string>($"{baseURL}/register", userInfo);

            if (!httpResponse.Success)
            {
                //throw new ApplicationException(await httpResponse.GetBody());

                return await httpResponse.GetBody();

            }

            return httpResponse.Response;
        }

        public async Task<UserToken> Login(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, UserToken>($"{baseURL}/login", userInfo);

            if (!httpResponse.Success)
            {
                //throw new ApplicationException(await httpResponse.GetBody());
            }

            return httpResponse.Response;
        }

    }
        
 }
