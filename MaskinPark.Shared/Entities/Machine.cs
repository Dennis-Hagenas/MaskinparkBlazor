namespace MaskinparkBlazor.Shared.Entities
{
    public class Machine
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");

        public string Name { get; set; } = "CPU Litografi";

        public bool OnlineStatus { get; set; } = true;

        public string Message { get; set; } = string.Empty;
    }
}