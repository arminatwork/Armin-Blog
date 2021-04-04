using System.Collections.Generic;
using System.Linq;
using AB.Domain.ArticleCategory;

namespace AB.Infrastructure.EfCore.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly ArminBlogContext _context;

        public ArticleCategoryRepository(ArminBlogContext context)
        {
            _context = context;
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.ToList();
        }

        public ArticleCategory Get(long id)
        {
            return _context.ArticleCategories.FirstOrDefault(first => first.Id == id);
        }


        public void Add(ArticleCategory articleCategory)
        {
            _context.ArticleCategories.Add(articleCategory);
            Save();
        }

        public bool Exists(string title)
        {
            return _context.ArticleCategories.Any(check => check.Title == title);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}