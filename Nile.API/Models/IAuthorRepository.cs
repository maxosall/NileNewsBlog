// using Microsoft.AspNetCore.Authorization;
using Nile.lib;

namespace Nile.API.Models;

public interface IAuthorRepository
{
    Task<IEnumerable<Author>> Search(string name, Gender? gender);
    Task<IEnumerable<Author>> GetAuthors();
    Task<Author> GetAuthorById(int id);
    Task<Author> GetAuthorByEmail(string email);
    Task<Author> AddAuthor(Author author);
    Task<Author> UpdateAuthor(Author author);
    Task<Author> DeleteAuthor(int id);
}
