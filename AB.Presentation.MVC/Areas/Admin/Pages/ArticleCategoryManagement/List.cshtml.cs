using System.Collections.Generic;
using AB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AB.Presentation.MVC.Areas.Admin.Pages.ArticleCategoryManagement
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategoryViewModels { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            ArticleCategoryViewModels = _articleCategoryApplication.List();
        }
    }
}
