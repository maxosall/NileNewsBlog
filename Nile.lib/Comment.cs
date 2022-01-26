using System.ComponentModel.DataAnnotations;

namespace Nile.lib
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}