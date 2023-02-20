using MaskinparkBlazor.Shared.Entities;

namespace MaskinparkBlazor.Services
{
    public class MaskinparkMockClient: IMaskinparkClient
    {
        private readonly HttpClient httpClient;

        public MaskinparkMockClient(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<IEnumerable<Machine>> GetAsync()
        {
            return new List<Machine>() { 
                new Machine()
                {
                    Name= "CPU Litografi",
                    Message = "Process started"
                },
                new Machine()
                {
                    Name= "CPU Assembly",
                    OnlineStatus= false,
                    Message = "Process OK"
                },
                new Machine()
                {
                    Name = "Box packaging"

                },
                new Machine()
                {
                    Name= "Wafer Assembly",
                    Message = "Process OK"

                },
                new Machine()
                {
                    Name= "Case part gluing",

                },
                new Machine()
                {
                    Name= "Air and temperature control",
                    Message = "Nominal values"

                }
            };
        }
    }
}
