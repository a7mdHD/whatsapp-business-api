using System.ComponentModel.DataAnnotations;

namespace WhatsAppBusiness.Settings;

public class WhatsAppConfig
{
    public static string SectionName = "WhatsAppConfig";
    [Required]
    public string WhatsAppApiUrl { get; set; } = string.Empty;
    [Required]
    public string WhatsAppApiType { get; set; } = string.Empty;
    [Required]
    public string WhatsAppToken { get; set; } = string.Empty;

}
