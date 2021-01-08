using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorPractice.Api.Data
{
    public class IdentityAppDbContext: IdentityDbContext
    {
        public IdentityAppDbContext(DbContextOptions<IdentityAppDbContext> opt):
            base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
