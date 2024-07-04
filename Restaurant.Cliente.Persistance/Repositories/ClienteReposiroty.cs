



using Restaurant.Cliente.Domain.Interfaces;
using System.Linq.Expressions;

namespace Restaurant.Cliente.Persistance.Repositories
{
    public class ClienteReposiroty : IClienteRepository
    {
        public bool Exists(Expression<Func<Domain.Entities.Cliente, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Cliente> GetClientesByEmpleadoId(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Cliente GetEntityBy(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Entities.Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void save(Domain.Entities.Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entities.Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
