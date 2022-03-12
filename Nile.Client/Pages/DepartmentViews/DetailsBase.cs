using Microsoft.AspNetCore.Components;
using Nile.Client.Services;
using Nile.lib;

namespace Nile.Client.Pages.DepartmentViews
{
    public class DetailsBase : ComponentBase
    {
        public List<Author> Authors { get; set; } = new List<Author>();
        public Department Department { get; set; } = new Department();
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public IAuthorService AuthorService { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Department = await DepartmentService.GetDepartmentById(int.Parse(Id));
            //Authors = (await AuthorService.GetAuthors()).ToList();
        }
        protected async Task AuthorDeleted()
        {
            Department = await DepartmentService.GetDepartmentById(int.Parse(Id));
        }
    }
}