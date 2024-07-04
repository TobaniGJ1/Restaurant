using Restaurant.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Empleado.Domain.Interfaces
{
        public interface IEmpleadoRepository : IBaseRepository<Domain.Entities.Empleado, int>
        {
        List<Empleado.Domain.Entities.Empleado> GetEmpleadosByClienteId(int clienteId);
            
        }
    }

