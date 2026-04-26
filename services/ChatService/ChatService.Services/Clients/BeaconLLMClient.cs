using DiscordService.Data.Records;

namespace DiscordService.API.Clients;

public class BeaconLLMClient(HttpClient httpClient, IConfiguration config) : IBeaconLLMClient
{
    public async Task<string> PromptAsync(PromptRequest promptRequest, CancellationToken ct = default)
    {
        var token = config["BeaconToken"];
        
        var response = await httpClient.PostAsync("/", new StringContent(promptRequest.Prompt), ct);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(ct);
    }
}