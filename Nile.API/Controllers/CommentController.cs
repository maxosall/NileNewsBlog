using Microsoft.AspNetCore.Mvc;
using Nile.API.Models;
using Nile.lib;

namespace Nile.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentRepository commentRepository;

    public CommentController(ICommentRepository commentRepository)
    {
        this.commentRepository = commentRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetComments()
    {
        try
        {
            return Ok(await commentRepository.GetComments());
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Comment>> GetCommentById(int id)
    {
        try
        {
            var result = await commentRepository.GetCommentById(id);
            if (result == null) return NotFound();
            return result;
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpPost]
    public async Task<ActionResult<Comment>> CreateComment(Comment comment)
    {
        try
        {
            if (comment == null) return BadRequest();
            var createdComment = await commentRepository.AddComment(comment);
            return CreatedAtAction(nameof(GetCommentById),
                new { id = createdComment.CommentId },
                createdComment);
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<Comment>> UpdateArticle(int id, Comment comment)
    {
        try
        {
            if (id == comment.CommentId) return BadRequest("Comment ID missmatch");

            var commentToUpdate = await commentRepository.GetCommentById(id);

            if (commentToUpdate == null)
                return NotFound($"Comment with id= {id} is not founf");

            return await commentRepository.UpdateComment(comment);
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
