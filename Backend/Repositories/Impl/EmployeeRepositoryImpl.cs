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

    public async Task<Employee> GetEmployeeByID(int id)
    {
        Employee employee = await _dbContext.Employees.FindAsync(id);
        return employee;
    }

    public async Task<bool> DeleteEmployee(int id)
    {
        Employee employee = await _dbContext.Employees.FindAsync(id);
        if (employee != null)
        {
            _dbContext.Employees.Remove(employee);
          
        }  await _dbContext.SaveChangesAsync();
            return true;
        return false;
    }

    public async Task<Employee> UpdateEmployee(Employee beforeUpdate)
    {
        _dbContext.Employees.Update(beforeUpdate);
        await _dbContext.SaveChangesAsync();
        return beforeUpdate;
    }
}