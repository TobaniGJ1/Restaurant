using WebApplication1.Web.Data.Models.Empleado;

namespace WebApplication1.Web.Data.Models.Empleado
{
    public class EmpleadoSaveModel : EmpleadoBaseModel
    {
        public string? Nombre { get; internal set; }
        public string? Cargo { get; set; }
    }
}
