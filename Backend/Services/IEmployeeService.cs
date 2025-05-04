using Backend.Dtos.Request;
using Backend.Dtos.Response;

namespace Backend.Services;

public interface IEmployeeService
{
    Task<EmployeeResponseDto> AddEmployee(EmployeeRequestDto employeeRequestDto);
    Task<ICollection<EmployeeResponseDto>> GetAllEmployees();
    Task<DepartmentResponseDto> GetDepartmentById(int id);
    Task<bool> DeleteEmployee(int id);
}