using DiscordService.Data.Records;

namespace DiscordService.API.Clients;

public interface IBeaconLLMClient
{
    Task<string> PromptAsync(PromptRequest promptRequest, CancellationToken ct = default);
}