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
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
    }


}