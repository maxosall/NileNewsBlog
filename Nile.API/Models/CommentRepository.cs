using Microsoft.EntityFrameworkCore;
using Nile.lib;

namespace Nile.API.Models;

public class CommentRepository : ICommentRepository
{
    private readonly AppDbContext context;
    public CommentRepository(AppDbContext appDbContext) => context = appDbContext;

    public async Task<Comment> AddComment(Comment comment)
    {
        var result = await context.Comments.AddAsync(comment);
        context.SaveChanges();
        return result.Entity;
    }

    public async Task<Comment> DeleteComment(int id)
    {
        var result = await context.Comments.FirstOrDefaultAsync(i => i.CommentId == id);
        if (result != null)
        {
            context.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }

    public async Task<Comment> GetCommentById(int id)
    {
        return await context.Comments
            .Include(a => a.Article)
            .ThenInclude(r => r.Author)
            .FirstOrDefaultAsync(x => x.CommentId == id);
    }

    public async Task<IEnumerable<Comment>> GetComments()
    {
        return await context.Comments
        .Include(c => c.Article)
        .ToListAsync();
    }

    public async Task<Comment> UpdateComment(Comment comment)
    {
        var result = await context.Comments
            .FirstOrDefaultAsync(i => i.CommentId == comment.CommentId);

        if (result != null)
        {
            result.CommentContent = comment.CommentContent;
            result.LastModifiedDate = comment.LastModifiedDate;

            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }
}
