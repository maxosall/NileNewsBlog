using Microsoft.AspNetCore.Components;

namespace Nile.Client.Pages.ArticalViews
{
    public class DeleteArticleBase : ComponentBase
    {
        public string DeleteArticle { get; set; }
        protected async override Task OnInitializedAsync()
        {
            DeleteArticle = "Delete Article";
        }
    }
}