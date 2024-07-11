using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurant.Cliente.Domain.Entities;
using Restaurant.Common.Data.Repository;

using System.Threading.Tasks;

namespace Restaurant.Cliente.Persistance.Interfaces
{
    public interface IClienteDb : IBaseRepository<Domain.Entities.Cliente,int>
    {
        List<Cliente.Domain.Entities.Cliente> GetClientesByEmpleadoId(int empleadoId);
        void RemoveCliente(Cliente.Persistance.Interfaces.IClienteDb clienteRemove);
    }
}
