using Lab2.BL.Manager.Departments;
using Lab2.BL.Manager.Tickets;
using Lab2.DAL.Data.Context;
using Lab2.DAL.Repos.Departments;
using Lab2.DAL.Repos.Tickets;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITicketRepo, TicketRepo>();
//builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();
 
builder.Services.AddScoped<ITicketManager, TicketManager>();
//builder.Services.AddScoped<IDepartmentManager, DepartmentManager>();

var connectionString = builder.Configuration.GetConnectionString("DBString");
builder.Services.AddDbContext<DevContext>(options => { options.UseSqlServer(connectionString); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
