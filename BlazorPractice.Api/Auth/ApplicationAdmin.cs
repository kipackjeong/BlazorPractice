using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlazorPractice.Api.Auth
{
    public class ApplicationAdmin : IdentityUser<Guid>
    {
    }
}
