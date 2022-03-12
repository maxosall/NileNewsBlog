using Microsoft.AspNetCore.Components;
using Nile.lib;

namespace Nile.Client.Pages.AuthorViews
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IAuthorService AuthorService { get; set; }
        public IEnumerable<Author> Authors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Authors = (await AuthorService.GetAuthors()).ToList();
        }
        protected async Task AuthorDeleted()
        {
            Authors = (await AuthorService.GetAuthors()).ToList();
        }
    }
}