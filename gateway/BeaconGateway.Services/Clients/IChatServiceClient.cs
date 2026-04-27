namespace BeaconGateway.Services.Clients;

public interface IChatServiceClient
{
    public Task<bool> SendPromptAsync(PromptRecord prompt);
}