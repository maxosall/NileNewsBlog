using Microsoft.AspNetCore.Mvc;
using Nile.API.Models;
using Nile.lib;

namespace Nile.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentRepository departmentRepository;
    public DepartmentsController(IDepartmentRepository departmentRepository) =>
        this.departmentRepository = departmentRepository;

    [HttpGet]
    public async Task<ActionResult> GetDepartments()
    {
        try
        {
            return Ok(await departmentRepository.GetDepartments());
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
            var result = await departmentRepository.GetDepartmentById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }
        catch (Exception)
        {
            return StatusCode500();
        }
    }

    [HttpPost]
    public async Task<ActionResult<Department>> AddDepartment(Department department)
    {
        try
        {
            if (department == null) return BadRequest();
            var deptName = await departmentRepository.GetDepartmentByName(department.DepartmentName);
            if (deptName != null)
            {
                ModelState.AddModelError("DepartmentName", $"[{deptName}] Dept Name is already in use");
                return BadRequest(ModelState);
            }
            var CreatedDepartment = await departmentRepository.AddDepartment(department);

            return CreatedAtAction(nameof(GetDepartmentById),
                new { id = CreatedDepartment.DepartmentId },
                CreatedDepartment);
        }
        catch (Exception)
        {
            return StatusCode500("Error POSTING data to the database");
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Department>> DeleteDepartment(int id)
    {
        try
        {
            var deptToDelete = await departmentRepository.GetDepartmentById(id);

            if (deptToDelete == null)
            {
                return NotFound($"Author with ID {id} not Found");
            }
            return await departmentRepository.DeleteDepartment(id);
        }
        catch (Exception)
        {
            return StatusCode500("Error DELETING data from the database");
        }
    }
    private ObjectResult StatusCode500(string statusCode = "Error RETRIEVING data from the database") =>
                        StatusCode(StatusCodes.Status500InternalServerError, statusCode);
}
