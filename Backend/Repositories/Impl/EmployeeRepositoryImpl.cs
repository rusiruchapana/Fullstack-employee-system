using Backend.Data;
using Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories.Impl;

public class EmployeeRepositoryImpl: IEmployeeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public EmployeeRepositoryImpl(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Employee> AddEmployee(Employee employee)
    {
        _dbContext.Employees.AddAsync(employee);
        await _dbContext.SaveChangesAsync();
        return employee;
    }

    public async Task<ICollection<Employee>> GetAllEmployees()
    {
        ICollection<Employee> employees = await _dbContext.Employees.Include(d=>d.Department).ToListAsync();
        return employees;
    }

    public async Task<Department> GetDepartmentById(int id)
    {
        Department department = await _dbContext.Departments.FindAsync(id);
        return department;
    }
}