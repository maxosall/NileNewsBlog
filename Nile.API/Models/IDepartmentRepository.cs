using System.Collections.Generic;
using Nile.lib;

namespace Nile.API.Models;

public interface IDepartmentRepository
{
    Task<IEnumerable<Department>> GetDepartments();
    Task<Department> GetDepartmentById(int id);
    Task<Department> AddDepartment(Department id);
    Task<Department> DeleteDepartment(int id);
    Task<Department> GetDepartmentByName(string name);
}
