using Microsoft.EntityFrameworkCore;
using Nile.lib;
using Mapster;
using Nile.API.Models.DTOs;


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
        // article.Author = null;
        // article.Comments = null;
        
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
            .AsNoTracking()
            .Include(r => r.Author)
            .Include(c => c.Comments)
            .FirstOrDefaultAsync(a => a.ArticleId == id);

    public async Task<IEnumerable<Article>> GetArticles() =>
        await context.Articles
            .Include(x => x.Author)
            .AsNoTracking()
            .OrderBy(x => x.Title)
            .ToListAsync();

    
    public async Task<IEnumerable<Article>> Search(string searchTerm)
    {
        // Check if the search term is null or empty then Return an empty list
        if (string.IsNullOrEmpty(searchTerm)) return new List<Article>();
        
        // Normalize the search term to lower case and trim whitespace
        searchTerm = searchTerm.ToLower().Trim();

        // Query the Articles DbSet for articles that match the search term in the Title or Content properties
        var articles = await context.Articles
            .Where(a => a.Title.ToLower().Contains(searchTerm) || 
                a.Content.ToLower().Contains(searchTerm))
            .ToListAsync();

        // Return the matching articles or an empty list if none found
        return articles;
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
