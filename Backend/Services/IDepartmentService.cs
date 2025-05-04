using Backend.Dtos.Request;
using Backend.Dtos.Response;

namespace Backend.Services;

public interface IDepartmentService
{
    Task<DepartmentResponseDto> AddDepartment(DepartmentRequestDto departmentRequestDto);
    Task<ICollection<DepartmentResponseDto>> GetAllDepartments();
    Task<DepartmentResponseDto> GetDepartmentById(int id);
    Task<bool> DeleteDepartment(int id);
    Task<DepartmentResponseDto> UpdateDepartment(int id, DepartmentRequestDto departmentRequestDto);
}