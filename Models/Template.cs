namespace WhatsAppBusiness.Models;
public class Template
{
    public string name { get; set; } = string.Empty;
    public Language language { get; set; } = default!;
    public List<Component> components { get; set; } = [];
}
