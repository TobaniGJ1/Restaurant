using Restaurant.Cliente.Persistance.Models.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Empleado.Persistance.Interfaces
{
    public interface IEmpleadoDb
    {
        void SaveEmpleado(EmpleadoSaveModel empleado);
        void UpdateEmpleado(EmpleadoUpdateModel updateModel);

        void RemoveEmpleado(EmpleadoRemoveModel empleadoRemove);

        List<EmpleadoGetModel> GetEmpleados();

        EmpleadoGetModel GetEmpleado(int IdEmpleado);
    }
}
