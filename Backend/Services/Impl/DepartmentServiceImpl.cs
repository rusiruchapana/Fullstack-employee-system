using Backend.Repositories;

namespace Backend.Services.Impl;

public class DepartmentServiceImpl: IDepartmentService
{
    private readonly IDepartmentRepository _departmentRepository;
    public DepartmentServiceImpl(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }
}