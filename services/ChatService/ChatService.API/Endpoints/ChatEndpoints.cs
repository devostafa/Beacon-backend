using Microsoft.AspNetCore.Mvc;

namespace ChatService.API.Endpoints;

public static class ChatEndpoints
{
    public static void MapChatEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/chat", () => "Hello World!").WithTags("Chat").RequireAuthorization();
    }
}