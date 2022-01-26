using Microsoft.AspNetCore.Components;

namespace Nile.Client.Pages.ArticalViews
{
    public class CreateArticleBase : ComponentBase
    {
        public string CreateArticle { get; set; }

        protected async override Task OnInitializedAsync()
        {
            CreateArticle = "Create An Article";
        }
    }
}