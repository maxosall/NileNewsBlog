using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nile.lib
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(65)]
        [Column(TypeName = "varchar(65)")]
        public string DepartmentName { get; set; }
        public virtual List<Author>? Authors { get; set; } = new List<Author>();
    }


}