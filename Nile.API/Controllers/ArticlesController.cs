using Microsoft.AspNetCore.Mvc;
using Nile.API.Models;
using Nile.lib;
using Nile.API.Models.DTOs;

namespace Nile.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class ArticlesController : ControllerBase
{
    private readonly IArticleRepository articleRepository;
    public ArticlesController(IArticleRepository articleRepository)
    {
        this.articleRepository = articleRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetArticles()
    {
        try
        { 
          var articles = await articleRepository.GetArticles();
          var responseDTO = (from a in articles
            select new ArticleResponseDTO
            {
              ArticleId = a.ArticleId,
              Title = a.Title,
              Content = a.Content,
              DatePublished = a.DatePublished,
              AuthorName = $"{a.Author?.FirstName} {a.Author?.LastName}"
            });
            return Ok(responseDTO);
        }
        catch (System.Exception)
        {
            return StatusCode500();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Article>> GetArticleById(int id)
    {
        try
        {
            var result = await articleRepository.GetArticleById(id);
            if (result == null) return NotFound();
            return result;
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateArticle(ArticleRequestDTO articleRequestDTO)
    {
      try
      {
        // if (!ModelState.IsValid)
        // {
        //     return BadRequest(ModelState);
        // }
        if (articleRequestDTO == null) return BadRequest();
        
        var article = new Article
        {
            ArticleId = articleRequestDTO.ArticleId,
            Title = articleRequestDTO.Title,
            Content = articleRequestDTO.Content,
            DatePublished = articleRequestDTO.DatePublished,
            AuthorId = articleRequestDTO.AuthorId
        };       

        var createdArticle = await articleRepository.AddArticle(article);


        // ARTICLE: Response     
      
       
        
        return CreatedAtAction(
          actionName: nameof(GetArticleById),
          routeValues: new { id = createdArticle.ArticleId },
          value: createdArticle);            
        }
        catch (Exception ex)
        {
          // Console.WriteLine($"ERROR MESSAGE: -> {ex.Message}");
            return StatusCode500();
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Article>> DeleteArticle(int id)
    {
        try
        {
            var ArticleToDelete = await articleRepository.GetArticleById(id);
            if (ArticleToDelete == null)
            {
                return NotFound($"Author with ID {id} not Found");
            }
            return await articleRepository.DeleteArticle(id);
        }
        catch (Exception)
        {
            return StatusCode500("Error DELETING data from the database");
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Article>> UpdateArticle(int id, Article article)
    {
        try
        {
            if (id == article.ArticleId) return BadRequest("Article ID missmatch");

            var articleToUpdate = await articleRepository.GetArticleById(id);

            if (articleToUpdate == null)
                return NotFound($"Article with id= {id} is not founf");

            return await articleRepository.UpdateArticle(article);
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }
    private ObjectResult StatusCode500(string statusCode = "Error retrieving data from the database") =>
                            StatusCode(StatusCodes.Status500InternalServerError,
                                statusCode);
}
