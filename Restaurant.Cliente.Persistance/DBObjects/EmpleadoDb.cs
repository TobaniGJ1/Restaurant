using WebApplication1.Web.Data.Models;
using WebApplication1.Web.Data.Context;
using WebApplication1.Web.Data.Exceptions;

using WebApplication1.Web.Data.Models.Empleado;

namespace Restaurant.Cliente.Persistance
{
    public class EmpleadoDb : IEmpleadoDb
    {
        private readonly RestaurantContext context;

        public EmpleadoDb(RestaurantContext context)
        {
            this.context = context;
        }
        public EmpleadoGetModel GetEmpleado(int IdEmpleado)
        {
            var empleado = this.context.Empleados.Find(IdEmpleado);
            EmpleadoGetModel empleadoModel = new EmpleadoGetModel()
            {
                IdEmpleado = empleado.IdEmpleado,
                Nombre = empleado.Nombre,
                Cargo = empleado.Cargo,
            };
            return empleadoModel;
        }

        public List<EmpleadoGetModel> GetEmpleados()
        {
            return this.context.Empleados.Select(empleado => new EmpleadoGetModel()
            {
                IdEmpleado = empleado.IdEmpleado,
                Nombre = empleado.Nombre,
                Cargo = empleado.Cargo,
            }).ToList();
        }

        public void RemoveEmpleado()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmpleado(EmpleadoRemoveModel empleadoRemove)
        {
            throw new NotImplementedException();
        }

        public void saveEmpleado(EmpleadoSaveModel empleadoSave)
        {
            Empleado empleado = new Empleado() 

            {
                IdEmpleado = empleadoSave.IdEmpleado,
                Nombre = empleadoSave.Nombre,
                Cargo = empleadoSave.Cargo,
            };
            this.context.Empleados.Add(empleado);
            this.context.SaveChanges(); 
        }

        public void UpdateEmpleado(EmpleadoUpdateModel updateModel)
        {
            Empleado empleadoToUpdate = this.context.Empleados.Find(updateModel.IdEmpleado);
            if (empleadoToUpdate == null)
            {
                throw new EmpleadoDbException("El empleado no se encuentra registrado.");
            }
            empleadoToUpdate.IdEmpleado = updateModel.IdEmpleado;
            empleadoToUpdate.Nombre = updateModel.Nombre;
            empleadoToUpdate.Cargo = updateModel.Cargo;

            this.context.Empleados.Update(empleadoToUpdate);
            this.context.SaveChanges();
        }
    }
}
