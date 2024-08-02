using WebApplication1.Web.Data.Models.Cliente;

namespace WebApplication1.Web.Data.Models
{
    public class ClienteUpdateModel : ClienteBaseModel
    {
        public int IdCliente { get; set; }
        public string? Nombre { get; internal set; }
    }
}
