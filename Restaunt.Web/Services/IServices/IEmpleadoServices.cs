namespace Restaunt.Web.Services.IServices
{
    public interface IEmpleadoServices
    {
        Task<EmpleadoGetListResult> GetList();
        Task<EmpleadoGetResult> GetById(int id);
        Task<EmpleadoGetResult> Save(EmpleadoSaveModel saveModel);
        Task<EmpleadoGetResult> Update(EmpleadoUpdateModel updateModel);

    }
}
