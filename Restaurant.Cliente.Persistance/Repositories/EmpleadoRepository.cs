using Restaurant.Cliente.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Cliente.Persistance.Repositories
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        public bool Exists(Expression<Func<Domain.Entities.Empleado, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Empleado> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Empleado> GetClientesByEmpleadoId(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Empleado GetEntityBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Entities.Empleado entity)
        {
            throw new NotImplementedException();
        }

        public void save(Domain.Entities.Empleado entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Empleado entity)
        {
            throw new NotImplementedException();
        }
    }
}
