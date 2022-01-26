using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nile.lib
{
    public class Creditor
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PoneNumber { get; set; }
        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string SSN { get; set; }
        public virtual Debte Debte { get; set; }
    }
}