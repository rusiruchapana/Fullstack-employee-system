using Backend.Data;
using Backend.Map;
using Backend.Repositories;
using Backend.Repositories.Impl;
using Backend.Services;
using Backend.Services.Impl;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), 
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));



// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddScoped<IDepartmentService , DepartmentServiceImpl>();
builder.Services.AddScoped<IDepartmentRepository , DepartmentRepositoryImpl>();
builder.Services.AddScoped<IEmployeeService , EmployeeServiceImpl>();
builder.Services.AddScoped<IEmployeeRepository , EmployeeRepositoryImpl>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

