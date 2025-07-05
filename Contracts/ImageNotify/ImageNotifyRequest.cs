namespace WhatsAppBusiness.Contracts.ImageNotify;

public class ImageNotifyRequest
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}
