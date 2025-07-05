namespace WhatsAppBusiness.Contracts.Notify;

public class NotifyRequest
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;

}
