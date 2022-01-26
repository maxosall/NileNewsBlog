using System.Net.Http.Json;
using Nile.lib;


namespace Nile.Services
{
    public class AuthorService : IAuthorService
    {
        // private string endPoint = "api/authors";
        private readonly HttpClient httpClient;
        public AuthorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await httpClient.GetFromJsonAsync<Author[]>("api/authors");
        }
    }
}