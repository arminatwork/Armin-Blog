using System.Globalization;
using System;
using System.Collections.Generic;
using AB.Application.Contracts.ArticleCategory;
using AB.Domain.ArticleCategory;

namespace AB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _repository;

        public ArticleCategoryApplication(IArticleCategoryRepository repository)
        {
            _repository = repository;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _repository.GetAll();
            var result = new List<ArticleCategoryViewModel>();
            foreach (var articleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = articleCategory.Id,
                    Title = articleCategory.Title,
                    IsDeleted = articleCategory.IsDeleted,
                    CreationDate = articleCategory.CreationDate.ToString(CultureInfo.InvariantCulture)
                });

            }
            
            return result;
        }
    }
}
