using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
    : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(SeedData.Movies);
        }
    }
}
