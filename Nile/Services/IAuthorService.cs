using Nile.lib;
namespace Nile.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthors();
    }
}