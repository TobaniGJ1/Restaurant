using WebApplication1.Web.Data.Models.Cliente;

namespace WebApplication1.Web.Data.Models
{
    public class ClienteSaveModel : ClienteBaseModel
    {
        public string? Nombre { get; internal set; }
    }
}
