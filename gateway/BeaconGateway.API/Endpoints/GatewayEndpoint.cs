namespace BeaconGateway.API.Endpoints;

public static class GatewayEndpoint
{
    public static void MapGtaewayEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/chat", async (HttpContext ctx, IHttpForwarder forwarder) =>
            {
                
                await forwarder.SendAsync(ctx, destination, ctx.RequestServices.GetRequiredService<HttpMessageInvoker>());
            })
            .RequireAuthorization();
    }
}