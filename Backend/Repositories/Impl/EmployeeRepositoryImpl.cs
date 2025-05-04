using Backend.Data;

namespace Backend.Repositories.Impl;

public class EmployeeRepositoryImpl: IEmployeeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public EmployeeRepositoryImpl(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}