using Nile.lib;

namespace Nile.Client
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthors();
        Task<Author> GetAuthorById(int id);
        Task<Author> CreateAuthor(Author newAuthor);
        Task<Author> UpdateAuthor(Author updatedAuthor);
        Task DeleteAuthor(int id);
    }
}