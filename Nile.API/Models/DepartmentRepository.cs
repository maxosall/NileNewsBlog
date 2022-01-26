using Microsoft.EntityFrameworkCore;
using Nile.lib;

namespace Nile.API.Models;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly AppDbContext context;
    public DepartmentRepository(AppDbContext appDbContext) =>
        this.context = appDbContext;

    public async Task<Department> GetDepartmentById(int id) =>
        await context.Departments
        .FirstOrDefaultAsync(d => d.DepartmentId == id);

    public async Task<IEnumerable<Department>> GetDepartments() =>
        await context.Departments
        .ToListAsync();
}
