namespace Nile.API.Models.DTOs;

public class ArticleResponseDTO{

  public int ArticleId { get; set; }
  public string Title { get; set; }
  public string Content { get; set; }
  public DateTime DatePublished { get; set; }
  public string AuthorName { get; set; }


  }