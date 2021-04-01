using System.Globalization;
using System.Collections.Generic;
using System.Linq;
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
            //need monitoring
            var articleCategories = _repository.GetAll().OrderByDescending(order => order.Id);

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
        public void Create(CreateArticleCategory command)
        {
            var articleCategory = new ArticleCategory(command.Title);
            _repository.Add(articleCategory);
        }

        public void Rename(RenameArticleCategory command)
        {
            var articleCategory = _repository.Get(command.Id);
            articleCategory.Rename(command.Title);
            _repository.Save();
        }
        public RenameArticleCategory Get(long id)
        {
            var articleCategory = _repository.Get(id);
            return new RenameArticleCategory
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title
            };
        }
    }
}
