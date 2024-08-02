using Restaunt.Web.Services.IServices;

namespace Restaunt.Web.Services.Services
{
    public class EmpleadoService : IEmpleadoServices
    {
        private readonly HttpClientHandler _httpClientHandler;
        private const string Url = "http://localhost:5042/api/Empleado/";
        public EmpleadoService()
        {
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
        }
        public async Task<EmpleadoeGetResult> GetById(int id)
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}GetCustomersById?id={id}";

                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<EmpleadoGetResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new EmpleadoGetResult { success = false, message = "Error al obtener el cliente." };
                    }
                }
            }
        }

        public async Task<EmpleadoGetListResult> GetList()
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}GetEmpleado";

                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<EmpleadoGetListResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new EmpleadoGetListResult { success = false, message = "Error al obtener la lista de Empleados." };
                    }
                }
            }
        }

        public async Task<EmpleadoGetResult> Save(EmpleadoSaveModel saveModel)
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}SaveEmpleado";
                var content = new StringContent(JsonConvert.SerializeObject(saveModel), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(url, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<EmpleadoGetResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new EmpleadoGetResult { success = false, message = "Error al guardar el cliente." };
                    }
                }
            }

        }

        public async Task<EmpleadoGetResult> Update(EmpleadoUpdateModel updateModel)
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}UpdateEmpleado";
                var content = new StringContent(JsonConvert.SerializeObject(updateModel), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(url, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<EmpleadoGetResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new EmpleadoGetResult { success = false, message = "Error al actualizar el cliente." };
                    }
                }
            }
        }
    }
}
