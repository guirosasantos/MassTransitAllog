using MassTransit;
using MassTransitAllog.Producer.Models;
using MassTransitAllog.Shared;
using Microsoft.AspNetCore.Mvc;

namespace MassTransitAllog.Producer.Controller;

[Route("api/Notification")]
[ApiController]
public class NotificationController : ControllerBase
{
    private readonly IPublishEndpoint _publishEndpoint;

    public NotificationController(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));
    }

    [HttpPost]
    public async Task<IActionResult> Notify(NotificationDto notificationDto)
    {
        await _publishEndpoint.Publish<INotificationCreated>(new
        {
            notificationDto.Date,
            notificationDto.Message,
            notificationDto.Author
        });
        return Ok();
    }
}
