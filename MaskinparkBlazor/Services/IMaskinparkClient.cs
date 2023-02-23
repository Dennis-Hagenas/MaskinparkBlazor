using MaskinparkBlazor.Shared.Entities;

namespace MaskinparkBlazor.Services
{
    public interface IMaskinparkClient
    {
        Task<IEnumerable<Machine>?> GetAsync();
        Task<Machine?> PostAsync(CreateMachine createmachine);
        Task<bool> PutAsync(Machine machine);
        Task<bool> RemoveAsync(string id);
    }
}