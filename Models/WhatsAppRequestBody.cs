using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppBusiness.Models;
public class WhatsAppRequestBody
{
    public string messaging_product { get; set; } = "whatsapp";
    public string recipient_type { get; set; } = "individual";
    public string to { get; set; } = string.Empty;
    public string type { get; set; } = "template";
    public Template template { get; set; } = default!;
}
