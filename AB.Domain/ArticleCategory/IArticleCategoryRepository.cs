using System.Collections.Generic;
namespace AB.Domain.ArticleCategory
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        // void Create(ArticleCategory articleCategory);
    }
}