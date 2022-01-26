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
            throw new NotImplementedException();
        }

        public void DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Article> GetArticleById(int id) =>
            await httpClient.GetFromJsonAsync<Article>($"api/Article/{id}");

        public async Task<IEnumerable<Article>> GetArticles() =>
            await httpClient.GetFromJsonAsync<IEnumerable<Article>>("api/Articles/");

        public Task<Article> UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}