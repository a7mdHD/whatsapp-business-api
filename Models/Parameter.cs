using System.Reflection.Metadata;

namespace WhatsAppBusiness.Models;

public class Parameter
{
    public string type { get; set; } = "text";
    public string text { get; set; } = string.Empty;
    public Image image { get; set; } = new();
    public Document document { get; set; } = new();
}

public class Image
{
    public string link { get; set; } = string.Empty;
}

public class Document
{
    public string link { get; set; } = string.Empty;
    public string filename { get; set; } = string.Empty;
}
