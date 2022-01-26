using System.Net.Http.Json;
using Nile.lib;

namespace Nile.Client
{
    public class AuthorService : IAuthorService
    {
        private readonly HttpClient httpClient;
        public AuthorService(HttpClient httpClient) =>
            this.httpClient = httpClient ??
            throw new ArgumentNullException(nameof(httpClient));

        public Task<Author> AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await httpClient.GetFromJsonAsync<Author>($"api/authors/{id}");
        }
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Author>>("api/authors");
        }

        public async Task<Author> UpdateAuthor(Author author)
        {
            //return await httpClient.PutAsync<Author>($"api/authors/{author.AuthorId}");
            throw new NotImplementedException();
        }
    }
}