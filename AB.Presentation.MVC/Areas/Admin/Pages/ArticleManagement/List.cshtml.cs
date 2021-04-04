using System.Collections.Generic;
using AB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AB.Presentation.MVC.Areas.Admin.Pages.ArticleManagement
{
    public class ListModel : PageModel
    {
        [BindProperty]
        public List<ArticleViewModel> Articles { get; set; }

        private readonly IArticleApplication _articleApplication;

        public ListModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = _articleApplication.List();
        }
    }
}
