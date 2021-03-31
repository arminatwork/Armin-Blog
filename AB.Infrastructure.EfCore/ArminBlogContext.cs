using AB.Domain.ArticleCategory;
using AB.Infrastructure.EfCore.Configurations;
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
            
            modelBuilder.ApplyConfiguration(new ArticleCategoryConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ArticleCategory> ArticleCategories { get; set; }

    }
}