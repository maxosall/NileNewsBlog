using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NileLib.Components;


// namespace Nile.lib;

public class NewsArticle
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime DatePublished { get; set; }
    public string Content { get; set; }
    public virtual ICollection<Tag> Tags { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    // public virtual ICollection<Comment> Comments { get; set; }
    // public virtual ICollection<Like> Likes { get; set; }
    // public virtual ICollection<Dislike> Dislikes { get; set; }
    // public virtual ICollection<Share> Shares { get; set; }
}

// public class Comment
// {
//     public int Id { get; set; }
//     public string Author { get; set; }
//     public DateTime DatePosted { get; set; }
//     public string Content { get; set; }
//     public virtual NewsArticle NewsArticle { get; set; }
//     public virtual User User { get; set; }
// }

// public class Like
// {
//     public int Id { get; set; }
//     public User User { get; set; }
//     public NewsArticle NewsArticle { get; set; }
// }

// public class Dislike
// {
//     public int Id { get; set; }
//     public User User { get; set; }
//     public NewsArticle NewsArticle { get; set; }
// }

// public class Share
// {
//     public int Id { get; set; }
//     public User User { get; set; }
//     public NewsArticle NewsArticle { get; set; }
// }

// public class Advertisement
// {
//     public int Id { get; set; }
//     public string Advertiser { get; set; }
//     public string AdType { get; set; }
//     public string AdSize { get; set; }
//     public string AdLocation { get; set; }
// }

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<NewsArticle> NewsArticles { get; set; }
}

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<NewsArticle> NewsArticles { get; set; }
}

public class Source
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<NewsArticle> NewsArticles { get; set; }
}

// public class Settings
// {
//     public string DefaultLanguage { get; set; }
//     public string DefaultTimezone { get; set; }
// }

// public async Task<IEnumerable<NewsArticle>> GetNewsArticlesByCategoryAsync(string category)
// {
//     using (var context = new NileContext())
//     {
//         return await context.NewsArticles
//             .Include(n => n.Categories)
//             .Where(n => n.Categories.Any(c => c.Name == category))
//             .ToListAsync();
//     }
// }
