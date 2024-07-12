
using Restaurant.Cliente.Domain.Entities;
using Restaurant.Cliente.Persistance.Context;
using Restaurant.Cliente.Persistance.Exceptions;
using Restaurant.Cliente.Persistance.Interfaces;
using Restaurant.Cliente.Persistance.Models.Cliente;

namespace Restaurant.Cliente.Persistance.DBObjects
{
    public class ClienteDb : IClienteDb
    {
        private readonly RestaurantContext context;

        public ClienteDb(RestaurantContext context)
        {
            this.context = context;
        }
        public ClienteGetModel GetCliente(int IdCliente)
        {
            var cliente = this.context.Clientes.Find(IdCliente);
            ClienteGetModel clienteModel = new ClienteGetModel()
            {
               
                IdCliente = cliente.IdCliente,
                Nombre = cliente.Nombre,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
            };
            return clienteModel;
        }

            public List<ClienteGetModel> GetClientes()
            {
                return this.context.Clientes.Select(cliente => new ClienteGetModel()
                {
                    IdCliente = cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Email = cliente.Email,
                }).ToList();
            }
            

        public void RemoveCliente(ClienteRemoveModel clienteRemove)
        {
            Restaurant.Cliente.Domain.Entities.Cliente clienteToDelete = this.context.Clientes.Find(clienteRemove.IdCliente);
        }

        public void SaveCliente(ClienteSaveModel clienteSave)
        {
            Restaurant.Cliente.Domain.Entities.Cliente cliente = new Restaurant.Cliente.Domain.Entities.Cliente()

            {
                IdCliente = clienteSave.IdCliente,
                Nombre = clienteSave.Nombre,
                Telefono = clienteSave.Telefono,
                Email = clienteSave.Email,
            };
            this.context.Clientes.Add(cliente);
            this.context.SaveChanges(); ;
        }

        public void UpdateCliente(ClienteUpdateModel updateModel)
        {
            Restaurant.Cliente.Domain.Entities.Cliente clienteToUpdate = this.context.Clientes.Find(updateModel.IdCliente);
            if (clienteToUpdate == null)
            {
                throw new ClienteDbException("El cliente no se encuentra registrado.");
            }
            clienteToUpdate.IdCliente = updateModel.IdCliente;
            clienteToUpdate.Nombre = updateModel.Nombre;
            clienteToUpdate.Telefono = updateModel.Telefono;
            clienteToUpdate.Email = updateModel.Email;

            this.context.Clientes.Update(clienteToUpdate);
            this.context.SaveChanges();
        }
    }
}
