using Backend.Services;

namespace Backend.Controllers;

public class EmployeeController
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

}