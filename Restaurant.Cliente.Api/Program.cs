using Microsoft.EntityFrameworkCore;
using Restaurant.Cliente.Persistance;
using Restaurant.Cliente.Persistance.Context;
using Restaurant.Cliente.Persistance.Interfaces;
using Restaurant.Cliente.Persistance.Repositories;
using RestaurantProMaCliente.IOC;
using RestaurantProMaCliente.IOC.Dependencies;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RestaurantContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantContext")));

builder.Services.AddControllers();

builder.Services.AddClienteDependency();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
