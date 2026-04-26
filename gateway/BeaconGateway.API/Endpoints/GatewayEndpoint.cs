namespace BeaconGateway.API.Endpoints;

public static class GatewayEndpoint
{
    public static void MapGatewayEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/chat", async () =>
            {
            })
            .RequireAuthorization();
    }
}