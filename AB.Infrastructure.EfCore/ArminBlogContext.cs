using AB.Domain.ArticleCategory;
using Microsoft.EntityFrameworkCore;

namespace AB.Infrastructure.EfCore
{
    public class ArminBlogContext : DbContext
    {
        public ArminBlogContext(DbContextOptions options) : base(options)
        {

        }

        //Model Creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configurationAssembly=typeof(ArticleCategory).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(configurationAssembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ArticleCategory> ArticleCategories { get; set; }

    }
}