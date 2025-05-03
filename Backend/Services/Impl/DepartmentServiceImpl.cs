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
}