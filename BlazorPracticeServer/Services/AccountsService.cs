using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Entity.Dtos;

namespace BlazorPracticeServer.Services
{
    public class AccountsService : IAccountsService
    {
        private readonly IApiBroker _apiBroker;
        private HttpClient _httpClient;

        public AccountsService(IApiBroker apiBroker, HttpClient httpClient)
        {
            _apiBroker = apiBroker;
            _httpClient = httpClient;
        }
        //TODO 1: Implement this
        public async ValueTask<UserToken> RegisterAccountAsync(UserInfo userInfo)
        => await _apiBroker.PostCreateAccountAsync(userInfo);

        public async ValueTask<UserToken> LoginAccountAsync(UserInfo userInfo)
            => await _apiBroker.PostLoginAccountAsync(userInfo);
    }
}
