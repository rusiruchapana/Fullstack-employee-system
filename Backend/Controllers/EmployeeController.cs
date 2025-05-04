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
    public async Task<ActionResult<EmployeeResponseDto>> GetEmployeeByID(int id)
    {
        EmployeeResponseDto employeeResponseDto = await _employeeService.GetEmployeeByID(id);
        if(employeeResponseDto != null)
            return Ok(employeeResponseDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<string>> DeleteEmployee(int id)
    {
        bool isDeleted = await _employeeService.DeleteEmployee(id);
        if(isDeleted)
            return Ok("Deleted employee.");
        return "Employee not found.";
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<EmployeeResponseDto>> UpdateEmployee(int id , EmployeeRequestDto employeeRequestDto)
    {
        EmployeeResponseDto employeeResponseDto = await _employeeService.UpdateEmployee(id, employeeRequestDto);
        if(employeeResponseDto != null)
            return Ok(employeeResponseDto);
        return NoContent();
    }


}