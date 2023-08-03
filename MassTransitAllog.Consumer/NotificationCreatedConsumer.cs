using System.Text.Json;
using MassTransit;
using MassTransitAllog.Shared;

namespace  MassTransitAllog.Consumer;

public class NotificationCreatedConsumer : IConsumer<INotificationCreated>
{
    public async Task Consume(ConsumeContext<INotificationCreated> context)
    {
        var message = JsonSerializer.Serialize(context.Message, new JsonSerializerOptions{});
        Console.WriteLine($"Message received From Producer: {message}");
    }

}