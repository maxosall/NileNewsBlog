using Microsoft.EntityFrameworkCore;
using Nile.lib;

namespace Nile.API.Models;

public class ArticleRepository : IArticleRepository
{
    private readonly AppDbContext context;
    public ArticleRepository(AppDbContext appDbContext)
    {
        this.context = appDbContext;
    }

    public async Task<Article> AddArticle(Article article)
    {
        var result = await context.Articles.AddAsync(article);
        await context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Article> DeleteArticle(int id)
    {
        var result = await context.Articles.FirstOrDefaultAsync(a => a.ArticleId == id);
        if (result != null)
        {
            context.Articles.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }

    public async Task<Article> GetArticleById(int id) =>
        await context.Articles
            .Include(r => r.Author)
            .ThenInclude(c => c.Comments)
            .FirstOrDefaultAsync(a => a.ArticleId == id);

    public async Task<IEnumerable<Article>> GetArticles() =>
        await context.Articles
            .Include(r => r.Author)
            .AsNoTracking()
            .OrderBy(x => x.Title)
            .ToListAsync();
    public async Task<IEnumerable<Article>> Search(string title)
    {
        IQueryable<Article> query = context.Articles;
        if (!string.IsNullOrEmpty(title))
        {
            query = query.Where(t => t.Title.ToLower().Contains(title));
        }
        return await query.ToListAsync();
    }

    public async Task<Article> UpdateArticle(Article article)
    {
        var result = await context.Articles
            .FirstOrDefaultAsync(a => a.ArticleId == article.ArticleId);

        if (result != null)
        {
            result.Title = article.Title;
            result.Content = article.Content;
            await context.SaveChangesAsync();

            return result;
        }
        return null;
    }
}
