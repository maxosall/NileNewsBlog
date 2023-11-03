using Nile.lib;

namespace Nile.Client.Services
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetArticles();
        Task<Article> GetArticleById(int id);
        Task<Article> AddArticle(Article article);
        Task<Article> UpdateArticle(Article article);
        Task DeleteArticle(int id);
    }
}