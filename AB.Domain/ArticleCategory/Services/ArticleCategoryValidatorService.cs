using AB.Domain.ArticleCategory.Exceptions;

namespace AB.Domain.ArticleCategory.Services
{
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
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
                throw new DuplicateRecordException($"{title} is already exists in database");
            }
        }
    }
}