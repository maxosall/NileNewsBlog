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
        .Include(x => x.Authors)
        .FirstOrDefaultAsync(d => d.DepartmentId == id);

    public async Task<IEnumerable<Department>> GetDepartments() =>
        await context.Departments
        .ToListAsync();


    public async Task<Department> AddDepartment(Department department)
    {
        var result = await context.Departments.AddAsync(department);
        await context.SaveChangesAsync();
        return result.Entity;
    }
    public async Task<Department> DeleteDepartment(int id)
    {
        var result = await context.Departments
            .FirstOrDefaultAsync(d => d.DepartmentId == id);
        if (result != null)
        {
            context.Departments.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }

    public async Task<Department> GetDepartmentByName(string name) =>
        await context.Departments.
        FirstOrDefaultAsync(m => m.DepartmentName.ToLower().Trim() == name.ToLower().Trim());
}
