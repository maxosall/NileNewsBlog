using Microsoft.AspNetCore.Components;
using Nile.lib;
using Nile.Services;

namespace Nile.Pages.AuthorViews
{
    public class AuthorListBase : ComponentBase
    {
        [Inject]
        public IAuthorService AuthorService { get; set; }
        public IEnumerable<Author>? Authors { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Authors = (await AuthorService.GetAuthors()).ToList();
        }
    }
}
