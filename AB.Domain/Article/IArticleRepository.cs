using System.Linq;
using AB.Application.Contracts.Article;

namespace AB.Domain.Article
{
    public interface IArticleRepository
    {
        IQueryable<ArticleViewModel> GetAll();
    }
}
