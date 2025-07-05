using Microsoft.AspNetCore.Mvc;
using WhatsAppBusiness.Contracts.ReminderNotify;
using WhatsAppBusiness.Services;

namespace WhatsAppBusiness.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WhatsAppController(ISendMessage sendMessage) : ControllerBase
{
    private readonly ISendMessage _sendMessage = sendMessage;

    [HttpPost("hello-world")]
    public async Task<IActionResult> HelloWorld(HelloWorldRequest request, CancellationToken cancellationToken)
    {
        var result = await _sendMessage.SendHelloWorld(request, cancellationToken);

        return Ok(result);
    }


    [HttpPost("notify")]
    public async Task<IActionResult> Notify(NotifyRequest request, CancellationToken cancellationToken)
    {
        var result = await _sendMessage.SendNotify(request, cancellationToken);

        return Ok(result);
    }

    [HttpPost("reminder-notify")]
    public async Task<IActionResult> ReminderNotify(ReminderNotifyRequest request, CancellationToken cancellationToken)
    {
        var result = await _sendMessage.SendReminderNotify(request, cancellationToken);

        return Ok(result);
    }

    [HttpPost("image-notify")]
    public async Task<IActionResult> ImageNotify(ImageNotifyRequest request, CancellationToken cancellationToken)
    {
        var result = await _sendMessage.SendImageNotify(request, cancellationToken);

        return Ok(result);
    }

    [HttpPost("doc-notify")]
    public async Task<IActionResult> DocNotify(DocNotifyRequest request, CancellationToken cancellationToken)
    {
        var result = await _sendMessage.SendDocNotify(request, cancellationToken);

        return Ok(result);
    }
}
