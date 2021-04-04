using AB.Domain.Article;
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
            modelBuilder.ApplyConfiguration(new ArticleConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}