using System.Collections.Generic;
using System.Linq;
using AB.Domain.ArticleCategory;

namespace AB.Infrastructure.EfCore.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly ArminBlogContext _context;

        public ArticleCategoryRepository(ArminBlogContext context)
        {
            _context = context;
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.ToList();
        }
    }
}