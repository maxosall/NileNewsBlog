using Nile.lib;

namespace Nile.API.Models;

public interface ICommentRepository
{
    Task<IEnumerable<Comment>> GetComments();
    Task<Comment> GetCommentById(int id);
    Task<Comment> AddComment(Comment comment);
    Task<Comment> UpdateComment(Comment comment);
    Task<Comment> DeleteComment(int id);
}
