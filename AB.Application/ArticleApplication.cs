using System.Collections.Generic;
using System.Linq;
using AB.Application.Contracts.Article;
using AB.Domain.Article;

namespace AB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _repository;

        public ArticleApplication(IArticleRepository repository)
        {
            _repository = repository;
        }

        public List<ArticleViewModel> List()
        {
            return _repository.GetAll().ToList();
        }
    }
}
