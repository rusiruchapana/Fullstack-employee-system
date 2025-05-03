using Backend.Data;
using Backend.Entities;

namespace Backend.Repositories.Impl;

public class DepartmentRepositoryImpl: IDepartmentRepository
{
    private readonly ApplicationDbContext _dbContext;
    public DepartmentRepositoryImpl(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Department> AddDepartment(Department department)
    { 
        _dbContext.AddAsync(department);
        await _dbContext.SaveChangesAsync();
        return department;
    }
}