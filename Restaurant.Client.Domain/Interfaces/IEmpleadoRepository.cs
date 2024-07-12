using Restaurant.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Cliente.Domain.Interfaces
{
        public interface IEmpleadoRepository : IBaseRepository<Domain.Entities.Empleado, int>
        {
       
        }
    }

