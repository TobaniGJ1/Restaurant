namespace Restaunt.Web.Services.IServices
{
    public interface IClienteServices
    {
        Task<ClienteGetListResult> GetList();
        Task<ClienteGetResult> GetById(int id);
        Task<ClienteGetResult> Save(ClienteSaveModel saveModel);
        Task<ClienteGetResult> Update(ClienteUpdateModel updateModel);




    }
}
