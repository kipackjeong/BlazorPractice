using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos;

namespace BlazorPracticeServer.Services
{
    public interface IAccountsService
    {
        ValueTask<UserToken> RegisterAccountAsync(UserInfo userInfo);
        ValueTask<UserToken> LoginAccountAsync(UserInfo userInfo);
    }
}
