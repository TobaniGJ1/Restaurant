

namespace Restaurant.Cliente.Persistance.Models.Cliente
{
    public class ClienteUpdateModel : ClienteBaseModel
    {
        public int IdCliente { get; set; }
        public string? Nombre { get; internal set; }
    }
}
