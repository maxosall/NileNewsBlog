using Nile.lib;

namespace Nile.Client
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthors();
        Task<Author> GetAuthorById(int id);
        Task<Author> AddAuthor(Author author);
        Task<Author> UpdateAuthor(Author author);
        void DeleteAuthor(int id);
    }
}