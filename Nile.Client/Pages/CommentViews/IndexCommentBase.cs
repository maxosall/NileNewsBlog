using Microsoft.AspNetCore.Components;

namespace Nile.Client.Pages.CommentViews
{
    public class IndexCommentBase : ComponentBase
    {
        public string Comments { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Comments = "Here is Comments";
        }
    }
}