using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

public class DepartmentController: ControllerBase
{
    private readonly IDepartmentService _departmentService;
    public DepartmentController(IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }
    
}