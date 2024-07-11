using Microsoft.Extensions.Logging;
using Restaurant.Cliente.Persistance.Core;
using Restaurant.Cliente.Persistance.Interfaces;
using Restaurant.Cliente.Persistance.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Cliente.Persistance.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteDb clienteDb;
        private readonly ILogger<ClienteService> logger;
        public ClienteService(IClienteDb clienteDb, ILogger<ClienteService> logger)
        {
            this.clienteDb = clienteDb;
            this.logger = logger;
        }

        public ServiceResult GetClientes()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = clienteDb.GetClientes();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los clientes";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetCliente(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = this.clienteDb.GetCliente(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los clientes";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
        public ServiceResult UpdateClientes(ClienteUpdateModel clienteUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (clienteUpdate is null)
                {
                    result.Success = false;
                    result.Message = "El cliente no puede ser nulo.";
                    return result;
                }
                if (string.IsNullOrEmpty(clienteUpdate.Nombre))
                {
                    result.Success = false;
                    result.Message = "El nombre del cliente es requerido";
                    return result;
                }
                if (clienteUpdate.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El nombre del cliente es solo puede tener 50 caracteres";
                    return result;
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando los datos";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveClientes(ClienteRemoveModel clienteRemove)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (clienteRemove is null)
                {
                    result.Success = false;
                    result.Message = "";
                    return result;
                }
                this.clienteDb.RemoveCliente(clienteRemove);
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando los datos";
                return result;

            }
            return result;
        }
        public ServiceResult SaveClientes(ClienteSaveModel clienteSave)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                if (clienteSave is null)
                {
                    result.Success = false;
                    result.Message = "El cliente no puede ser nulo.";
                    return result;
                }
                if (string.IsNullOrEmpty(clienteSave.Nombre))
                {
                    result.Success = false;
                    result.Message = "El nombre del cliente es requerido";
                    return result;
                }
                if (clienteSave.Nombre.Length > 50)
                {
                    result.Success = false;
                    result.Message = "El nombre del cliente es solo puede tener 50 caracteres";
                    return result;
                }
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos";

            }
            return result;
        }
    }
}

