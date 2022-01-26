using System.Threading.Tasks;
using Nile.lib;

namespace Nile.Client.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartmentById(int id);
    }
}