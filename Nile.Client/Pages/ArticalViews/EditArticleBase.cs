using Microsoft.AspNetCore.Components;
using Nile.lib;

namespace Nile.Client.Pages.ArticalViews
{
    public class EditArticleBase : ComponentBase
    {
        public string Edit { get; set; }
        public Article Article { get; set; }
        //public IArticleService ArticleService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Edit = "Edit Article";
            Article = new Article { Title = "", Content = "", PublishDate = DateTime.Now };
        }
    }
}