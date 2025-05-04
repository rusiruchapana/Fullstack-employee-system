using Backend.Repositories;

namespace Backend.Services.Impl;

public class EmployeeServiceImpl: IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeServiceImpl(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
}