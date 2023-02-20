using MaskinPark.Shared;

namespace MaskinparkBlazor.Services
{
    public class MaskinparkClient
    {
        private readonly HttpClient httpClient;

        public MaskinparkClient(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<IEnumerable<Machine>> GetAsync()
        {

        }
    }
}
