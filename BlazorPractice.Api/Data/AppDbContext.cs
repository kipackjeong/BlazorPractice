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
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> opt)
        :base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>()
                .HasKey(bc => new { bc.MovieId, bc.GenreId });
            modelBuilder.Entity<MovieGenre>()
                .HasOne(bc => bc.Movie)
                .WithMany(b => b.MovieGenres)
                .HasForeignKey(bc => bc.MovieId);
            modelBuilder.Entity<MovieGenre>()
                .HasOne(bc => bc.Genre)
                .WithMany(c => c.MovieGenres)
                .HasForeignKey(bc => bc.GenreId);
        }
    }
}
