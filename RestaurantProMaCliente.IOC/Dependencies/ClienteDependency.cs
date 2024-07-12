using Microsoft.Extensions.DependencyInjection;
using Restaurant.Cliente.Domain.Entities;
using Restaurant.Cliente.Persistance;
using Restaurant.Cliente.Persistance.Interfaces;
using Restaurant.Cliente.Persistance.Repositories;
using Restaurant.Cliente.Persistance.Services;
using Restaurant.Empleado.Persistance.Interfaces;
using Restaurant.Cliente.Domain;
using System.Runtime.CompilerServices;
using Restaurant.Cliente.Domain.Interfaces;

namespace RestaurantProMaCliente.IOC.Dependencies
{
    public static class ClienteDependency
    {
        public static void AddClienteDependency(this IServiceCollection service)
        {
            #region"Repositorios"
            service.AddScoped<IClienteRepository, ClienteRepository>();
            service.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            #endregion

            #region"Services"
            service.AddTransient<IClienteService, ClienteService>();
            #endregion
        }
    }
}
