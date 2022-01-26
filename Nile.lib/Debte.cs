using System.ComponentModel.DataAnnotations.Schema;

namespace Nile.lib
{

    public class Debte
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PaidDate { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string DebteForm { get; set; }
        public virtual List<Creditor> Creditors { get; set; }
    }

}