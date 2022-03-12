using Microsoft.AspNetCore.Components;
using Nile.Client.Services;
using Nile.lib;

namespace Nile.Client.Shared.Components;

public class FooterBase : ComponentBase
{
    [Inject]
    public IDepartmentService DepartmentService { get; set; }
    [Inject]
    public IEnumerable<Department> Departments { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Departments = (await DepartmentService.GetDepartments()).ToList();
    }
}
