

using Restaurant.Cliente.Domain.Entities;
using Restaurant.Cliente.Persistance.Context;
using Restaurant.Cliente.Persistance.Exceptions;
using Restaurant.Cliente.Persistance.Interfaces;
using Restaurant.Cliente.Persistance.Models.Empleado;
using Restaurant.Empleado.Persistance.Interfaces;
using Restaurant;

namespace Restaurant.Cliente.Persistance.DBObjects
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

        public void RemoveEmpleado(EmpleadoRemoveModel empleadoRemove)
        {
            Restaurant.Cliente.Domain.Entities.Empleado empleadoToDelete = this.context.Empleados.Find(empleadoRemove.IdEmpleado);
        }


        public void SaveEmpleado(EmpleadoSaveModel empleadoSave)
        {
            Restaurant.Cliente.Domain.Entities.Empleado empleado = new Restaurant.Cliente.Domain.Entities.Empleado() 

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
            Restaurant.Cliente.Domain.Entities.Empleado empleadoToUpdate = this.context.Empleados.Find(updateModel.IdEmpleado);
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
