using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _accountUrl = "api/accounts";
        //TODO 3: Implement APIBroker for Account
        public async ValueTask<UserToken> PostCreateAccountAsync(UserInfo userInfo) => 
            await PostAsync<UserInfo, UserToken>(_accountUrl + "/create", userInfo);

        public async ValueTask<UserToken> PostLoginAccountAsync(UserInfo userInfo) =>
            await PostAsync<UserInfo, UserToken>(_accountUrl + "/login", userInfo);
    }
}
