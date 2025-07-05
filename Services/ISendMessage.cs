using WhatsAppBusiness.Contracts;
using WhatsAppBusiness.Contracts.ReminderNotify;

namespace WhatsAppBusiness.Services;

public interface ISendMessage
{
    Task<NotifyResponse> SendHelloWorld(HelloWorldRequest request, CancellationToken cancellationToken = default);
    Task<NotifyResponse> SendNotify(NotifyRequest request, CancellationToken cancellationToken = default);
    Task<NotifyResponse> SendReminderNotify(ReminderNotifyRequest request, CancellationToken cancellationToken = default);
    Task<NotifyResponse> SendImageNotify(ImageNotifyRequest request, CancellationToken cancellationToken = default);
    Task<NotifyResponse> SendDocNotify(DocNotifyRequest request, CancellationToken cancellationToken = default);
}
