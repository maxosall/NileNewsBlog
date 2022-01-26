using Microsoft.AspNetCore.Components;

namespace Nile.Client.Pages.ArticalViews
{
    public class IndexArticleBase : ComponentBase
    {
        public string Index { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Index = "All Articles";
        }
    }
}