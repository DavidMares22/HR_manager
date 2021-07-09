using HR_manager.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_manager.Client.Repository
{
    public interface IAccountsRepository
    {
        Task<List<string>> Login(UserLogin userInfo);
        Task<List<string>> Register(UserInfo userInfo);
        
    }
}
