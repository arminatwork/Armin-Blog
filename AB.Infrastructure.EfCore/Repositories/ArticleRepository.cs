using AB.Domain.Article;

namespace AB.Infrastructure.EfCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly IArticleRepository _repository;

        public ArticleRepository(IArticleRepository repository)
        {
            _repository = repository;
        }
    }
}
