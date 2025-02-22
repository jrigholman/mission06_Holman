using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mission06_Holman.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Inception", Category = "Sci-Fi", Director = "Christopher Nolan", Year = 2010, Rating = "PG-13" },
                new Movie { MovieId = 2, Title = "The Dark Knight", Category = "Action", Director = "Christopher Nolan", Year = 2008, Rating = "PG-13" },
                new Movie { MovieId = 3, Title = "The Prestige", Category = "Drama", Director = "Christopher Nolan", Year = 2006, Rating = "PG-13" }
            );
        }
    }
}
