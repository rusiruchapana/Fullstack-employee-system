using Backend.Entities;

namespace Backend.Repositories;

public interface IDepartmentRepository
{
    Task<Department> AddDepartment(Department department);
    Task<ICollection<Department>> GetAllDepartments();
    Task<Department> GetDepartmentById(int id);
    Task<bool> DeleteDepartment(int id);
    Task<Department> UpdateDepartment(Department beforeUpdateDpartment);
}