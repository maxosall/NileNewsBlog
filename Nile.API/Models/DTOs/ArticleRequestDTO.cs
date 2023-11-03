namespace Nile.API.Models.DTOs;
public class ArticleRequestDTO{
  public int ArticleId {get; set;}
  public string Title {get; set;}
  public string Content {get; set;}
  public DateTime DatePublished {get; set;}
  public int AuthorId{get;set;}
}