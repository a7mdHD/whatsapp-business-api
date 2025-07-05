namespace WhatsAppBusiness.Models;

public class Component
{
    public string type { get; set; } = string.Empty;
    public string sub_type { get; set; } = "url";
    public string index { get; set; } = "0";
    public List<Parameter> parameters { get; set; } = [];

}
