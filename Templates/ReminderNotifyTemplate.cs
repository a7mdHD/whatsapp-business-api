
using WhatsAppBusiness.Contracts.ReminderNotify;

namespace WhatsAppBusiness.Templates;

public class ReminderNotifyTemplate(ReminderNotifyRequest request) : IBaseTemplate
{
    public Template CreateTemplate()
    {
        Template template = new Template
        {
            name = "notify_reminder",
            language = new Language(),
            components = new List<Component>
                {
                    new Component
                    {
                        type = "body",
                        parameters = new List<Parameter>
                        {
                            new Parameter {
                                text = request.PaymentFor
                            },
                            new Parameter {
                                text = request.CardNumber
                            },
                            new Parameter {
                                text = request.ReminderDate
                            }
                        }
                    }
                }
        };

        return template;
    }
}
