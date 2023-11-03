using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nile.lib
{
    public class Article
    {
        public int ArticleId { get; set; }

        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        // [Index(IsUnique = true)]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Content { get; set; }

        public DateTime DatePublished { get; set; } = DateTime.Now;

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; } = new ();
        public virtual ICollection<Category> Categories { get; set; }
        public virtual List<Comment>? Comments { get; set; } = new List<Comment>(); 
        
        // public virtual List<Comment>? Comments => Author?.Comments;      
    }
}

/*
Some features you could add to your web app are:

- A gallery of popular meme templates and captions that users can browse and select.
- A tool to edit the text and image of the meme, such as changing the font, size, color, position, etc.
- A preview of the meme before saving or sharing it.
- A button to download the meme as an image file or copy the link to share it on social media.
- A rating system to let users vote for their favorite memes and see the most liked ones.
- A comment section to let users give feedback and interact with each other.
*/