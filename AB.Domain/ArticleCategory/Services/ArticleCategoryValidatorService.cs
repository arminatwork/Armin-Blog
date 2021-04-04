using System;

namespace AB.Domain.ArticleCategory.Services
{
    class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository _repository;

        public ArticleCategoryValidatorService(IArticleCategoryRepository repository)
        {
            _repository = repository;
        }
        public void AlreadyExistsRecord(string title)
        {
            if (_repository.Exists(title))
            {
                throw new Exception();
            }
        }
    }
}