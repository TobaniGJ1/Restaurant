

using Restaurant.Cliente.Persistance.Core;
using Restaurant.Cliente.Persistance.Models.Empleado;

namespace Restaurant.Cliente.Persistance.Interfaces
{
    public interface IEmpleadoService
    {
        ServiceResult GetEmpleados();
        ServiceResult GetEmpleados(int id);

        ServiceResult UpdateEmpleados(EmpleadoUpdateModel empleadoUpdate);

        ServiceResult RemoveEmpleados(EmpleadoRemoveModel empleadoRemove);

        ServiceResult SaveEmpleados(EmpleadoSaveModel empleadoSave);
    }
}
