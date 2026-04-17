using DiscordService.API.Clients;
using DiscordService.API.Routes;
using DiscordService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
var config = builder.Configuration;

builder.Services.AddOpenApi();

builder.Services.AddHttpClient<IBeaconLLMClient, BeaconLLMClient>(client =>
{
    client.BaseAddress = new Uri(config["BeaconLLM:BaseUrl"]);
    client.Timeout = TimeSpan.FromSeconds(config.GetValue<int>("BeaconLLM:TimeoutSeconds"));
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapDiscordRoutes();

app.Run();