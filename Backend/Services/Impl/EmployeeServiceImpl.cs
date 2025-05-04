using AutoMapper;
using Backend.Dtos.Request;
using Backend.Dtos.Response;
using Backend.Entities;
using Backend.Repositories;

namespace Backend.Services.Impl;

public class EmployeeServiceImpl: IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeServiceImpl(IEmployeeRepository employeeRepository , IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<EmployeeResponseDto> AddEmployee(EmployeeRequestDto employeeRequestDto)
    {
        Employee employee = _mapper.Map<Employee>(employeeRequestDto);
        Employee afterAdding = await _employeeRepository.AddEmployee(employee);
        return(_mapper.Map<EmployeeResponseDto>(afterAdding));
    }

    public async Task<ICollection<EmployeeResponseDto>> GetAllEmployees()
    {
        ICollection<Employee> employees = await _employeeRepository.GetAllEmployees();
        return (_mapper.Map<ICollection<EmployeeResponseDto>>(employees));
    }

    public async Task<EmployeeResponseDto> GetEmployeeByID(int id)
    {
        Employee employee = await _employeeRepository.GetEmployeeByID(id);
        return _mapper.Map<EmployeeResponseDto>(employee);
    }

    public async Task<bool> DeleteEmployee(int id)
    {
        bool isDeleted = await _employeeRepository.DeleteEmployee(id);
        return isDeleted;
    }

    public async Task<EmployeeResponseDto> UpdateEmployee(int id, EmployeeRequestDto employeeRequestDto)
    {
        Employee beforeUpdate = await _employeeRepository.GetEmployeeByID(id);
        beforeUpdate.FirstName = employeeRequestDto.FirstName;
        beforeUpdate.LastName = employeeRequestDto.LastName;
        beforeUpdate.Email = employeeRequestDto.Email;
        beforeUpdate.DateOfBirth = employeeRequestDto.DateOfBirth;
        beforeUpdate.HireDate = employeeRequestDto.HireDate;
        beforeUpdate.Position = employeeRequestDto.Position;
        beforeUpdate.Salary = employeeRequestDto.Salary;
        beforeUpdate.DepartmentId = employeeRequestDto.DepartmentId;

        Employee afterUpdate = await _employeeRepository.UpdateEmployee(beforeUpdate);
        return(_mapper.Map<EmployeeResponseDto>(afterUpdate));
    }
}