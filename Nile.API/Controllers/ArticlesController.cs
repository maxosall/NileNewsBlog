using Microsoft.AspNetCore.Mvc;
using Nile.API.Models;
using Nile.lib;

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
    public async Task<ActionResult> GetArticles()
    {
        try
        {
            return Ok(await articleRepository.GetArticles());
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
    public async Task<ActionResult<Article>> CreateArticle(Article article)
    {
        try
        {
            if (article == null) return BadRequest();
            var createdArticle = await articleRepository.AddArticle(article);
            return CreatedAtAction(nameof(GetArticleById),
                new { id = createdArticle.ArticleId },
                createdArticle);
        }
        catch (Exception)
        {
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
