using ArticleWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArticleWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyBlogContext myBlogContext;

        public IndexModel(ILogger<IndexModel> logger, MyBlogContext _blogContext)
        {
            _logger = logger;
            myBlogContext = _blogContext;
        }

        public void OnGet()
        {
           var post = (from p in myBlogContext.articles
                      orderby p.CreatedAt
                      select p).ToList();
            ViewData["post"] = post;
        }
    }
}
