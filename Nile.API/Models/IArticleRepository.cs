using Nile.lib;

namespace Nile.API.Models;

public interface IArticleRepository
{
    Task<IEnumerable<Article>> Search(string title);
    Task<IEnumerable<Article>> GetArticles();
    Task<Article> GetArticleById(int id);
    Task<Article> AddArticle(Article article);
    Task<Article> UpdateArticle(Article article);

    Task<Article> DeleteArticle(int id);

}
