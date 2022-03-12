using System.Net.Http;
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

        public async Task<Author> CreateAuthor(Author newAuthor)
        {
            var response = await httpClient.PostAsJsonAsync<Author>($"api/authors", newAuthor);
            return await response.Content.ReadFromJsonAsync<Author>();
        }

        public async Task DeleteAuthor(int id)
        {
            await httpClient.DeleteAsync($"api/authors/{id}");
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await httpClient.GetFromJsonAsync<Author>($"api/authors/{id}");
        }
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Author>>("api/authors");
        }

        public async Task<Author> UpdateAuthor(Author updatedAuthor)
        {
            var response = await httpClient.PutAsJsonAsync<Author>("api/authors", updatedAuthor);
            return await response.Content.ReadFromJsonAsync<Author>();
        }
    }
}