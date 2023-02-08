using System.Net.Http.Json;
using Nile.lib;

namespace Nile.Client.Services
{
    public class ArticleService : IArticleService
    {
        private readonly HttpClient httpClient;
        public ArticleService(HttpClient httpClient) =>
            this.httpClient = httpClient ??
                throw new ArgumentNullException(nameof(httpClient));

        public async Task<Article> AddArticle(Article article)
        {
            var response = await httpClient.PostFromJsonAsync("api/articles", article);
            return await response.Content.ReadFromJsonAsync<Article>();
        }

        public void DeleteArticle(int id)
        {
            await httpClient.DeleteAsync($"api/articles/{id}");
        }

        public async Task<Article> GetArticleById(int id) =>
            await httpClient.GetFromJsonAsync<Article>($"api/articles/{id}");

        public async Task<IEnumerable<Article>> GetArticles() =>
            await httpClient.GetFromJsonAsync<IEnumerable<Article>>("api/articles/");

        public Task<Article> UpdateArticle(Article article)
        {
            var response = await httpClient.PutAsJsonAsync<Article>("api/articles", article);
            return await response.Content.ReadFromJsonAsync<Article>();
        }
    }
}