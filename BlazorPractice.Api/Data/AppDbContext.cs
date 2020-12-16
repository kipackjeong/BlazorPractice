using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorPractice.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> opt)
        :base(opt)
        {
            
        }
    }
}
