namespace WhatsAppBusiness.Contracts.DocNotify;

public class DocNotifyRequest
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string ReceiverName { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}
