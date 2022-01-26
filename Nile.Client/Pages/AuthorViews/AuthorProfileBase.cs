using Microsoft.AspNetCore.Components;
using Nile.lib;

namespace Nile.Client.Pages.AuthorViews
{
    public class AuthorProfileBase : ComponentBase
    {
        public Author Author { get; set; } = new Author();
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IAuthorService AuthorService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Author = await AuthorService.GetAuthorById(int.Parse(Id));
            //bio = await SliceBio();
        }
    }
}