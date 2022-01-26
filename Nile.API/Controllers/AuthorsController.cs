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
            Console.WriteLine("-- Fetching Data From AUTHOR Table succeed it --");
            return Ok(await authorRepository.GetAuthors());
        }
        catch (Exception)
        {
            Console.WriteLine("-- Fetching Data From AUTHOR Table Failed! -- ");
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

            var athr = authorRepository.GetAuthorByEmail(author.Email);
            if (athr != null)
            {
                ModelState.AddModelError("email", "author's email is already in use");
                return BadRequest(ModelState);
            }
            var createdAuthor = await authorRepository.AddAuthor(author);
            return CreatedAtAction(nameof(GetAuthorById),
                new { id = createdAuthor.AuthorId },
                createdAuthor);
        }
        catch (Exception)
        {
            return StatusCode500("Error posting data to the database");
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Author>> UpdateAuthor(int id, Author author)
    {
        try
        {
            if (id != author.AuthorId) return BadRequest("Author ID missmatch");

            var authorToUpdate = await authorRepository.GetAuthorById(id);

            if (authorToUpdate == null)
                return NotFound($"Author with id= {id} is not founf");
            return await authorRepository.UpdateAuthor(author);
        }
        catch (Exception)
        {
            return StatusCode500("Error updating data from the database");
        }
    }

    [HttpGet("{search}")]
    public async Task<ActionResult<IEnumerable<Author>>> Search(string name, Gender? gender)
    {
        try
        {
            var result = await authorRepository.Search(name, gender);
            if (result.Any()) return Ok(result);
            return NotFound();
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
