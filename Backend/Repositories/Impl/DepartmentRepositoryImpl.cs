using Backend.Data;

namespace Backend.Repositories.Impl;

public class DepartmentRepositoryImpl: IDepartmentRepository
{
    private readonly ApplicationDbContext _dbContext;
    public DepartmentRepositoryImpl(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}