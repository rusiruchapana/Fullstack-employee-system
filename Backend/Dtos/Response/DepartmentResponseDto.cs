using Backend.Entities;

namespace Backend.Dtos.Response;

public class DepartmentResponseDto
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime EstablishedDate { get; set; } = DateTime.UtcNow;
    public ICollection<Employee> Employees { get; set; }
}