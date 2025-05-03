using AutoMapper;
using Backend.Dtos.Request;
using Backend.Dtos.Response;
using Backend.Entities;

namespace Backend.Map;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<DepartmentRequestDto, Department>();
        CreateMap<Department, DepartmentResponseDto>();
    }
}