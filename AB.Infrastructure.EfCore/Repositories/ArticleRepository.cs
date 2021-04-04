using System.Linq;
using AB.Application.Contracts.Article;
using AB.Domain.Article;
using Microsoft.EntityFrameworkCore;

namespace AB.Infrastructure.EfCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ArminBlogContext _context;

        public ArticleRepository(ArminBlogContext context)
        {
            _context = context;
        }

        public IQueryable<ArticleViewModel> GetAll()
        {
            return _context.Articles
                .Include(inc => inc.ArticleCategory)
                .Select(sel => new ArticleViewModel
                {
                    Id = sel.Id,
                    Title = sel.Title,
                    ShortDescription = sel.ShortDescription,
                    CreationDate = sel.CreationDate.ToString(),
                    IsDeleted = sel.IsDeleted,
                    ArticleCategory = sel.ArticleCategory.Title
                });
        }
    }
}
