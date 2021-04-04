using System;
using System.Collections.Generic;
using AB.Domain.ArticleCategory.Services;

namespace AB.Domain.ArticleCategory
{
    public class ArticleCategory
    {
        public long Id { get; private set; }

        public string Title { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTime CreationDate { get; private set; }
        public ICollection<Article.Article> Articles { get; private set; }

        public ArticleCategory(string title, IArticleCategoryValidatorService service)
        {
            service.AlreadyExistsRecord(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            Articles = new List<Article.Article>();
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public void Remove(long id)
        {
            IsDeleted = true;
        }

        public void Activate(long id)
        {
            IsDeleted = false;
        }
    }
}