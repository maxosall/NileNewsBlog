using Nile.lib;

namespace Nile.Client.Services;

public interface ICommentService
{
    Task<IEnumerable<Comment>> GetArticles();
    Task<Comment> GetArticleById(int id);
    Task<Comment> AddArticle(Comment article);
    Task<Comment> UpdateArticle(Comment article);
    void DeleteArticle(int id);
}
