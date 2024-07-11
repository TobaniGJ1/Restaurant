
namespace Restaurant.Cliente.Persistance.Models.Empleado
{
    public class EmpleadoSaveModel : EmpleadoBaseModel
    {
        public string? Nombre { get; internal set; }
        public string? Cargo { get; set; }
    }
}
