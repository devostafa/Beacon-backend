using DiscordService.API.Clients;
using DiscordService.Data.Records;

namespace DiscordService.API.Routes;

public static class DiscordRoutes
{
    public static IEndpointRouteBuilder MapDiscordRoutes(this IEndpointRouteBuilder app)
    {
        app.MapPost("/prompt", async (IBeaconLLMClient client, PromptRequest promptRequest, CancellationToken ct) =>
        {
            var response = await client.PromptAsync(promptRequest, ct);

            return Results.Ok(response);
        });

        return app;
    }
}