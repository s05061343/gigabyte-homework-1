using Microsoft.EntityFrameworkCore;

namespace gigabyte_homework.Models.Application
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Specification> Specifications => Set<Specification>();
        public DbSet<News> News => Set<News>();
        public DbSet<Image> Images => Set<Image>();
        public DbSet<Tag> Tags => Set<Tag>();
    }
}
