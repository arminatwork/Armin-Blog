using System.Collections.Generic;
namespace AB.Domain.ArticleCategory
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        ArticleCategory Get(long id);
        void Add(ArticleCategory articleCategory);
        void Save();
    }
}