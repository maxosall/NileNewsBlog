using Microsoft.AspNetCore.Mvc;
using Nile.API.Models;
using Nile.lib;

namespace Nile.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private readonly ILogger<Author> _logger;
    private readonly IAuthorRepository authorRepository;

    public AuthorsController(IAuthorRepository authorRepository,
        ILogger<Author> logger)
    {
        _logger = logger;
        this.authorRepository = authorRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetAuthors()
    {
        try
        {
            return Ok(await authorRepository.GetAuthors());
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Author>> GetAuthorById(int id)
    {
        try
        {
            var result = await authorRepository.GetAuthorById(id);
            if (result == null) return NotFound();
            return result;
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpPost]
    public async Task<ActionResult<Author>> CreateAuthor(Author author)
    {
        try
        {
            if (author == null) return BadRequest();

            var authorEmail = await authorRepository.GetAuthorByEmail(author.Email);
            if (authorEmail != null)
            {
                ModelState.AddModelError("email", "author's email is already in use");
                return BadRequest(ModelState);
            }
            var createdAuthor = await authorRepository.AddAuthor(author);
            return CreatedAtAction(nameof(GetAuthorById),
                new { id = createdAuthor.AuthorId }, createdAuthor);
        }
        catch (Exception)
        {
            return StatusCode500("Error POSTING data to the database");
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Author>> DeleteAuthor(int id)
    {
        try
        {
            // if(id == null) return NotFound("Author ID missmatch");
            var authorToDelete = await authorRepository.GetAuthorById(id);
            return authorToDelete == null
                ? (ActionResult<Author>)NotFound($"Author with ID {id} not Found")
                : (ActionResult<Author>)await authorRepository.DeleteAuthor(id);
        }
        catch (Exception)
        {
            return StatusCode500("Error DELETING data from the database");
        }
    }

    [HttpPut]
    public async Task<ActionResult<Author>> UpdateAuthor(Author author)
    {
        try
        {
            //if (id != author.AuthorId) return BadRequest("Author ID missmatch");
            var authorToUpdate = await authorRepository.GetAuthorById(author.AuthorId);

            return authorToUpdate == null
                ? (ActionResult<Author>)NotFound($"Author with ID= {author.AuthorId} is not found")
                : (ActionResult<Author>)await authorRepository.UpdateAuthor(author);
        }
        catch (Exception)
        {
            return StatusCode500("Error UPDATING data from the database");
        }
    }

    [HttpGet("{search}")]
    public async Task<ActionResult<IEnumerable<Author>>> Search(string name, Gender? gender)
    {
        try
        {
            var result = await authorRepository.Search(name, gender);
            if (result.Any()) return Ok(result);
            return NotFound("Not Found");
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }
    private ObjectResult StatusCode500(string statusCode = "Error retrieving data from the database") =>
                        StatusCode(StatusCodes.Status500InternalServerError, statusCode);
}
