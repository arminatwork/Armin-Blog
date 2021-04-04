using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using AB.Application.Contracts.ArticleCategory;
using AB.Domain.ArticleCategory;
using AB.Domain.ArticleCategory.Services;

namespace AB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _repository;
        private readonly IArticleCategoryValidatorService _service;

        public ArticleCategoryApplication(IArticleCategoryRepository repository, IArticleCategoryValidatorService service)
        {
            _repository = repository;
            _service = service;
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
            var articleCategory = new ArticleCategory(command.Title, _service);
            _repository.Add(articleCategory);
        }

        public void Rename(RenameArticleCategory command)
        {
            var articleCategory = _repository.Get(command.Id);
            articleCategory.Rename(command.Title);
            _repository.Save();
        }

        public void Remove(long id)
        {
            var articleCategory = _repository.Get(id);
            articleCategory.Remove(id);
            _repository.Save();
        }

        public void Activate(long id)
        {
            var articleCategory = _repository.Get(id);
            articleCategory.Activate(id);
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
