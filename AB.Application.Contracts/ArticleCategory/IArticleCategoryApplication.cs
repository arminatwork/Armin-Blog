using System.Collections.Generic;

namespace AB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        RenameArticleCategory Get(long id);
        void Create(CreateArticleCategory command);
        void Rename(RenameArticleCategory command);
        void Remove(long id);
        void Activate(long id);
    }
}
