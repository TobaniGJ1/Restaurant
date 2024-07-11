using Restaurant.Cliente.Persistance.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Cliente.Persistance.Interfaces
{
    public interface IClienteDb
    {
        void SaveCliente(ClienteSaveModel cliente);
        void UpdateCliente(ClienteUpdateModel updateModel);

        void RemoveCliente(ClienteRemoveModel clienteRemove);

        List<ClienteGetModel> GetClientes();

        ClienteGetModel GetCliente(int IdCliente);
    }
}