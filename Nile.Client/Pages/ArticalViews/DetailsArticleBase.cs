using Microsoft.AspNetCore.Components;

namespace Nile.Client.Pages.ArticalViews
{
    public class DetailsArticleBase : ComponentBase
    {
        public string Details { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Details = "Details";
        }
    }
}