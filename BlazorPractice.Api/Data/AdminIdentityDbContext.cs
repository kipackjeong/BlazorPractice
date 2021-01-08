using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorPractice.Api.Data
{
    public class AdminIdentityDbContext : IdentityDbContext
    {
        public AdminIdentityDbContext(DbContextOptions<AdminIdentityDbContext> opt)
        :base(opt)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
