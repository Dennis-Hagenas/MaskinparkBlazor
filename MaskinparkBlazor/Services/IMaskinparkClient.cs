using MaskinparkBlazor.Shared.Entities;

namespace MaskinparkBlazor.Services
{
    public interface IMaskinparkClient
    {
        Task<IEnumerable<Machine>> GetAsync();
    }
}