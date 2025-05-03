using Backend.Entities;

namespace Backend.Repositories;

public interface IDepartmentRepository
{
    Task<Department> AddDepartment(Department department);
}