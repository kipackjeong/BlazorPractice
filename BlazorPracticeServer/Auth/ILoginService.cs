using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos;

namespace BlazorPracticeServer.Auth
{
    public interface ILoginService
    {
        Task Login(UserToken token);
        Task Logout();
    }
}
