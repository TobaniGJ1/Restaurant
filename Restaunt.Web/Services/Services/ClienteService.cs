using Newtonsoft.Json;
using Restaunt.Web.Services;
using Restaunt.Web.Services.IServices;
using System.Text;
namespace Restaunt.Web.Services.Services
{
    public class ClienteService : IClienteServices
    {
        private readonly HttpClientHandler _httpClientHandler;
        private const string Url = "http://localhost:5042/api/Cliente/";
        public ClienteServices()
        {
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
        }
        public async Task<ClienteGetResult> GetById(int id)
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}GetCustomersById?id={id}";

                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<CustomersGetResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new ClienteGetResult { success = false, message = "Error al obtener el cliente." };
                    }
                }
            }
        }

        public async Task<ClienteGetListResult> GetList()
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}GetCliente";

                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<ClienteGetListResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new ClienteGetListResult { success = false, message = "Error al obtener la lista de Clientes." };
                    }
                }
            }
        }

        public async Task<ClienteGetResult> Save(ClienteSaveModel saveModel)
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}SaveCliente";
                var content = new StringContent(JsonConvert.SerializeObject(saveModel), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(url, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<ClienteGetResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new ClienteGetResult { success = false, message = "Error al guardar el cliente." };
                    }
                }
            }

        }

        public async Task<ClienteGetResult> Update(ClienteUpdateModel updateModel)
        {
            using (var httpClient = new HttpClient(_httpClientHandler))
            {
                var url = $"{Url}UpdateCliente";
                var content = new StringContent(JsonConvert.SerializeObject(updateModel), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(url, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<ClienteGetResult>(apiResponse);
                        return result;
                    }
                    else
                    {
                        return new ClienteGetResult { success = false, message = "Error al actualizar el cliente." };
                    }
                }
            }
        }
    }
}