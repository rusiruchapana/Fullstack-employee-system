using Backend.Dtos.Request;
using Backend.Dtos.Response;

namespace Backend.Services;

public interface IDepartmentService
{
    Task<DepartmentResponseDto> AddDepartment(DepartmentRequestDto departmentRequestDto);
}