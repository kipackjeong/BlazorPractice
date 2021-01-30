using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorPractice.Api.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MoviePerson> MoviePeople { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> opt)
        : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>()
                .HasKey(bc => new { bc.MovieId, bc.GenreId });
            //modelBuilder.Entity<MovieGenre>()
            //    .HasOne(bc => bc.Movie)
            //    .WithMany(b => b.MovieGenres)
            //    .HasForeignKey(bc => bc.MovieId);
            //modelBuilder.Entity<MovieGenre>()
            //    .HasOne(bc => bc.Genre)
            //    .WithMany(c => c.MovieGenres)
            //    .HasForeignKey(bc => bc.GenreId);

            modelBuilder.Entity<MoviePerson>().HasKey(x => new { x.MovieId, x.PersonId });
            //modelBuilder.Entity<MoviePerson>()
            //    .HasOne(bc => bc.Movie)
            //    .WithMany(b => b.MoviePeople)
            //    .HasForeignKey(bc => bc.MovieId);
            //modelBuilder.Entity<MoviePerson>()
            //    .HasOne(bc => bc.Person)
            //    .WithMany(c => c.MoviePeople)
            //    .HasForeignKey(bc => bc.PersonId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
