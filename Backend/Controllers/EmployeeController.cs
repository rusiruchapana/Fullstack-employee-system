using Backend.Dtos.Request;
using Backend.Dtos.Response;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class EmployeeController: ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    public async Task<ActionResult<EmployeeResponseDto>> AddEmployee(EmployeeRequestDto employeeRequestDto)
    {
        EmployeeResponseDto employeeResponseDto = await _employeeService.AddEmployee(employeeRequestDto);
        if (employeeResponseDto != null)
            return Ok(employeeResponseDto);
        
        return BadRequest("Failed to add employee.");
    }

    [HttpGet]
    public async Task<ActionResult<ICollection<EmployeeResponseDto>>> GetAllEmployees()
    {
        ICollection<EmployeeResponseDto> employeeResponseDtos = await _employeeService.GetAllEmployees();
        if(employeeResponseDtos != null)
            return Ok(employeeResponseDtos);
        return NoContent();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<DepartmentResponseDto>> GetDepartmentById(int id)
    {
        DepartmentResponseDto departmentResponseDto = await _employeeService.GetDepartmentById(id);
        if(departmentResponseDto != null)
            return Ok(departmentResponseDto);
        return NoContent();
    }




}