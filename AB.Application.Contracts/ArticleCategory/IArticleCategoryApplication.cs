using System.Collections.Generic;
using System;

namespace AB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
    }
}
