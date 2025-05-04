using AutoMapper;
using Backend.Dtos.Request;
using Backend.Dtos.Response;
using Backend.Entities;
using Backend.Repositories;

namespace Backend.Services.Impl;

public class DepartmentServiceImpl: IDepartmentService
{
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IMapper _mapper;
    public DepartmentServiceImpl(IDepartmentRepository departmentRepository, IMapper mapper)
    {
        _departmentRepository = departmentRepository;
        _mapper = mapper;
    }

    public async Task<DepartmentResponseDto> AddDepartment(DepartmentRequestDto departmentRequestDto)
    {
        Department department = await _departmentRepository.AddDepartment(_mapper.Map<Department>(departmentRequestDto));
        return _mapper.Map<DepartmentResponseDto>(department);
    }

    public async Task<ICollection<DepartmentResponseDto>> GetAllDepartments()
    {
        ICollection<Department> departments = await _departmentRepository.GetAllDepartments();
        return _mapper.Map<ICollection<DepartmentResponseDto>>(departments);
    }

    public async Task<DepartmentResponseDto> GetDepartmentById(int id)
    {
        Department department = await _departmentRepository.GetDepartmentById(id);
        return _mapper.Map<DepartmentResponseDto>(department);
    }

    public async Task<bool> DeleteDepartment(int id)
    {
        bool isDeleted = await _departmentRepository.DeleteDepartment(id);
        return isDeleted;
    }
    
    public async Task<DepartmentResponseDto> UpdateDepartment(int id, DepartmentRequestDto departmentRequestDto)
    {
        Department beforeUpdateDpartment = await _departmentRepository.GetDepartmentById(id);
        beforeUpdateDpartment.Name = departmentRequestDto.Name;
        beforeUpdateDpartment.Description = departmentRequestDto.Description;

        Department afterUpdateDepartment = await _departmentRepository.UpdateDepartment(beforeUpdateDpartment);
        return(_mapper.Map<DepartmentResponseDto>(afterUpdateDepartment));
    }
}