using BeaconGateway.Services.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace BeaconGateway.Services;

public static class ServicesRegister
{
    public static void RegisterServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IChatServiceClient, ChatServiceClient>();
        serviceCollection.AddScoped<IDiscordServiceClient, DiscordServiceClient>();
    }
}