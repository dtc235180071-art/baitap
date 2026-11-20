using baitap.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace baitap.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dữ liệu mẫu bảng Genre
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Hành động" },
                new Genre { Id = 2, Name = "Hoạt hình" }
            );

            // Dữ liệu mẫu bảng Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Jumanji", ReleaseDate = new DateTime(2017, 1, 1), Duration = 120, GenreId = 1 },
                new Movie { Id = 2, Title = "Doraemon", ReleaseDate = new DateTime(2020, 1, 1), Duration = 90, GenreId = 2 }
            );
        }
    }
}