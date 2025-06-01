using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

namespace Backend.Entities;

public class Department
{
    public int DepartmentId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime EstablishedDate { get; set; } = DateTime.UtcNow;
    
    // [JsonIgnore]
    public ICollection<Employee>? Employees { get; set; }
}