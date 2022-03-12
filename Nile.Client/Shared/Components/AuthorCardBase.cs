using Microsoft.AspNetCore.Components;
using Nile.Client.Services;

using Nile.lib;

namespace Nile.Client.Shared.Components;

public class AuthorCardBase : ComponentBase
{
    [Inject]
    public IAuthorService AuthorService { get; set; }
    [Parameter]
    public Author Author { get; set; }
    [Parameter]
    public EventCallback<int> OnAuthorDeleted { get; set; }

    protected NileLib.Components.ConfirmBase DeleteConfirmation { get; set; }

    // protected void Delete_Click()
    // {
    //     DeleteConfirmation.Show();
    // }
    protected async Task Delete_Click()
    {
        await AuthorService.DeleteAuthor(Author.AuthorId);
        await OnAuthorDeleted.InvokeAsync(Author.AuthorId);
    }
}
