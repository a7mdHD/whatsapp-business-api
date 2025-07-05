namespace WhatsAppBusiness.Contracts.ReminderNotify;

public class ReminderNotifyRequest
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string ReceiverName { get; set; } = string.Empty;
    public string PaymentFor { get; set; } = string.Empty;
    public string CardNumber { get; set; } = string.Empty;
    public string ReminderDate { get; set; } = string.Empty;
}
