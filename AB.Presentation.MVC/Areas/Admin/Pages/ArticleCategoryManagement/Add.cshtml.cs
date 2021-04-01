using AB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AB.Presentation.MVC.Areas.Admin.Pages.ArticleCategoryManagement
{
    public class AddModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public AddModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }

        public RedirectToPageResult OnPost(CreateArticleCategory command)
        {
            _articleCategoryApplication.Create(command);
            return RedirectToPage("List");
        }
    }
}
