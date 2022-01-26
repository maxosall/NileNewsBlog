using System.Net.Http.Json;
using Nile.lib;

namespace Nile.Client.Services
{
    public class CommentService : ICommentService
    {
        private readonly HttpClient httpClient;
        public CommentService(HttpClient httpClient) =>
            this.httpClient = httpClient ??
                throw new ArgumentNullException(nameof(httpClient));

        public Task<Comment> AddArticle(Comment article)
        {
            throw new NotImplementedException();
        }

        public void DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Comment> GetArticleById(int id) =>
            await httpClient.GetFromJsonAsync<Comment>($"api/Comments/{id}");

        public async Task<IEnumerable<Comment>> GetArticles() =>
            await httpClient.GetFromJsonAsync<IEnumerable<Comment>>("api/Comments");

        public Task<Comment> UpdateArticle(Comment article)
        {
            throw new NotImplementedException();
        }
    }
}