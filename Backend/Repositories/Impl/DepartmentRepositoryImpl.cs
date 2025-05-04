using Backend.Data;
using Backend.Entities;
using Microsoft.EntityFrameworkCore;

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

    public async Task<ICollection<Department>> GetAllDepartments()
    {
        ICollection<Department> departments = await _dbContext.Departments.ToListAsync();
        return departments;
    }

    public async Task<Department> GetDepartmentById(int id)
    {
        Department department = await _dbContext.Departments.FindAsync(id);
        return department;
    }

    public async Task<bool> DeleteDepartment(int id)
    {
        Department department = await _dbContext.Departments.FindAsync(id);
        if (department != null)
        {
            _dbContext.Departments.Remove(department);
            await _dbContext.SaveChangesAsync();
            return true;
        }


        return false;
    }

    public async Task<Department> UpdateDepartment(Department beforeUpdateDpartment)
    {
        _dbContext.Departments.Update(beforeUpdateDpartment);
        await _dbContext.SaveChangesAsync();
        return beforeUpdateDpartment;
    }
}