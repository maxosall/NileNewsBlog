using Microsoft.AspNetCore.Mvc;
using Nile.API.Models;
using Nile.lib;

namespace Nile.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentRepository context;
    public DepartmentsController(IDepartmentRepository departmentRepository) =>
        this.context = departmentRepository;

    [HttpGet]
    public async Task<ActionResult> GetDepartments()
    {
        try
        {
            return Ok(await context.GetDepartments());
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Department>> GetDepartmentById(int id)
    {
        try
        {
            var result = await context.GetDepartmentById(id);
            if (result == null) return NotFound();
            return result;
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }
    private ObjectResult StatusCode500() =>
                        StatusCode(StatusCodes.Status500InternalServerError,
                            "Error retrieving data from the database");
}
