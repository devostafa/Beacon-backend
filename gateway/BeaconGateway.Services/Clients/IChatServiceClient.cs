namespace BeaconGateway.Services.Clients;

public class IChatServiceClient
{
    public Task<bool> SendPromptAsync(PromptModel prompt);
}