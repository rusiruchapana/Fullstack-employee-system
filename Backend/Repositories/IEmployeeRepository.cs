using Backend.Entities;

namespace Backend.Repositories;

public interface IEmployeeRepository
{
    Task<Employee> AddEmployee(Employee employee);
    Task<ICollection<Employee>> GetAllEmployees();
    Task<Employee> GetEmployeeByID(int id);
    Task<bool> DeleteEmployee(int id);

    Task<Employee> UpdateEmployee(Employee beforeUpdate);
}