namespace BeaconGateway.Services.Clients;

public class ChatServiceClient(HttpClient httpClient, IConfiguration config) : IChatServiceClient
{
    
    public async Task<bool> SendPromptAsync(PromptRecord prompt)
    {
        
    }
}