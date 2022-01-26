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
        // pulic string[] slicedBio = Author.Bio.ToString().Split(Author.Bio[100]);
        // protected string GetBio()
        // {           

        //     if (Author.Bio.Length < 100)
        //     {
        //         return slicedBio = Author.Bio;
        //     }
        //     else
        //     {
        //         return slicedBio = Author.Bio[0];
        //     }
        // }
    }
}