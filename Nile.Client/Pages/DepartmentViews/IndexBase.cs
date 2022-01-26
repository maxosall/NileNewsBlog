using Microsoft.AspNetCore.Components;
using Nile.Client.Services;
using Nile.lib;

namespace Nile.Client.Pages.DepartmentViews
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetDepartments()).ToList();
        }
    }
}