using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NileLib.Components;


namespace Nile.lib
{
    public class Author
    {
        [Required]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(200)]
        [Display(Name = "Last Name")]
        [EmailDomainValidator(AllowedDomain = "gmail.com")]
        [Column(TypeName = "varchar(200)")]
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public Gender? Gender { get; set; }

        [MinLength(300, ErrorMessage = "The is has to at least 300 char")]
        [MaxLength(450, ErrorMessage = "The is has to at most 450 char")]
        [Column(TypeName = "varchar(450)")]
        public string? Bio { get; set; }
        public string? PhotoPath { get; set; }

        public int DepartmentId { get; set; }
        public virtual List<Article> Articles { get; set; } = new List<Article>();
        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
        public virtual Department? Department { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}