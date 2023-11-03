namespace Nile.lib;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    [InverseProperty("Categories")]
    public virtual ICollection<Article> Articles { get; set; }
}