using AB.Application;
using AB.Application.Contracts.Article;
using AB.Application.Contracts.ArticleCategory;
using AB.Domain.Article;
using AB.Domain.ArticleCategory;
using AB.Domain.ArticleCategory.Services;
using AB.Infrastructure.EfCore;
using AB.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AB.Infrastructure.Core
{
    public static class Bootstrapper
    {
        public static void Configure(this IServiceCollection services, string connectionString)
        {
            //ArticleCategory
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryValidatorService, ArticleCategoryValidatorService>();

            //Article
            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();


            //Database
            services.AddDbContext<ArminBlogContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
