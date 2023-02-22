using MaskinparkBlazor.Shared.Entities;
using System.Net.Http.Json;

namespace MaskinparkBlazor.Services
{
    public class MaskinparkClient: IMaskinparkClient
    {
        private readonly HttpClient httpClient;

        public MaskinparkClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }



        public async Task<IEnumerable<Machine>?> GetAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Machine>>("api/machines");
        }


        public async Task<Machine?> PostAsync(CreateMachine machine)
        {
            var response = await httpClient.PostAsJsonAsync("api/machines", machine);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<Machine>() : null;
        }


        public async Task<bool> RemoveAsync(string id)
        {
            return (await httpClient.DeleteAsync($"api/machines/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(Machine machine)
        {
            return (await httpClient.PutAsJsonAsync($"api/machines/{machine.Id}", machine)).IsSuccessStatusCode;
        }



    }
}
