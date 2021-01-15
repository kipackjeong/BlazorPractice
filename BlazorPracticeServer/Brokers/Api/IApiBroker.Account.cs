using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial interface IApiBroker
    {
        //TODO 2: Implement IApiBroker for Account
        ValueTask<UserToken> PostCreateAccountAsync(UserInfo userInfo);
        ValueTask<UserToken> PostLoginAccountAsync(UserInfo userInfo);
    }
}
