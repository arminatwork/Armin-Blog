using System.Collections.Generic;

namespace AB.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> List();
    }
}
