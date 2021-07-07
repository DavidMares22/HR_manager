﻿using HR_manager.Client.Helper;
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


        public async Task<List<string>> Register(UserInfo userInfo)
        {


            var httpResponse = await httpService.Post<UserInfo, string>($"{baseURL}/register", userInfo);

            if (!httpResponse.Success)
            {

                List<string> error = new List<string>();
                error.Add("Error: ");
                ErrorResponse errorMessage = await httpResponse.GetBody();

                error.Add(errorMessage.ToString());

                return error;

            }

            SuccessResponse successMessage = await httpResponse.GetBodySuccess();
            List<string> success = new List<string>();
            success.Add("Success: ");
            success.Add(successMessage.success);
            return success;
        }

        public async Task<List<string>> Login(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, UserToken>($"{baseURL}/login", userInfo);

            if (!httpResponse.Success)
            {
                List<string> error = new List<string>();
                error.Add("Error: ");

                ErrorResponse errorMessage = await httpResponse.GetBody();

                error.Add(errorMessage.ToString());


                return error;
            }

            UserToken token = await httpResponse.GetBodyLogin();
            List<string> success = new List<string>();
            success.Add("Success: ");
            success.Add(token.token);

            return success;
        }

    }
        
 }
