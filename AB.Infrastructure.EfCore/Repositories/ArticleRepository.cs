using AB.Domain.Article;

namespace AB.Infrastructure.EfCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ArminBlogContext _context;

        public ArticleRepository(ArminBlogContext context)
        {
            _context = context;
        }

    }
}
