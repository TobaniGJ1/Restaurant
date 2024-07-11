

using Restaurant.Cliente.Persistance.Core;
using Restaurant.Cliente.Persistance.Models.Cliente;

namespace Restaurant.Cliente.Persistance.Interfaces
{
    public interface IClienteService 
    {
        ServiceResult GetClientes();
        ServiceResult GetCliente(int id);

        ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate);

        ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove);

        ServiceResult SaveClientes(ClienteSaveModel clienteSave);
    }
}
