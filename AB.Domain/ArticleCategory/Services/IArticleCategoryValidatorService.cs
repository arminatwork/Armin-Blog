namespace AB.Domain.ArticleCategory.Services
{
    public interface IArticleCategoryValidatorService
    {
        void AlreadyExistsRecord(string title);
    }
}
