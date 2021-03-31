using AB.Application;
using AB.Application.Contracts.ArticleCategory;
using AB.Domain.ArticleCategory;
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
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddDbContext<ArminBlogContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
