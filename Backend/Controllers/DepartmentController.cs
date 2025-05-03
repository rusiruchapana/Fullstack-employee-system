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

}