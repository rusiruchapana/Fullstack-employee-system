using Backend.Dtos.Request;
using Backend.Dtos.Response;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DepartmentController: ControllerBase
{
    private readonly IDepartmentService _departmentService;
    public DepartmentController(IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpPost]
    public async Task<ActionResult<DepartmentResponseDto>> AddDepartment(DepartmentRequestDto departmentRequestDto)
    {
        DepartmentResponseDto departmentResponseDto = await _departmentService.AddDepartment(departmentRequestDto);
        return Ok(departmentResponseDto);
    }

    [HttpGet]
    public async Task<ActionResult<ICollection<DepartmentResponseDto>>> GetAllDepartments()
    {
        ICollection<DepartmentResponseDto> departmentResponseDtos = await _departmentService.GetAllDepartments();
        if (departmentResponseDtos == null)
            return NoContent();
        return Ok(departmentResponseDtos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DepartmentResponseDto>> GetDepartmentById(int id)
    {
        DepartmentResponseDto departmentResponseDto = await _departmentService.GetDepartmentById(id);
        if (departmentResponseDto == null)
            return NoContent();
        return Ok(departmentResponseDto);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<string>> DeleteDepartment(int id)
    {
        bool isDeleted = await _departmentService.DeleteDepartment(id);
        if (isDeleted)
            return ("Department deleted");
        return("Department not found");
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<DepartmentResponseDto>> UpdateDepartment(int id , DepartmentRequestDto departmentRequestDto)
    {
        DepartmentResponseDto departmentResponseDto = await _departmentService.UpdateDepartment(id , departmentRequestDto);
        if(departmentResponseDto == null)
            return NoContent();
        return Ok(departmentResponseDto);
    }


}