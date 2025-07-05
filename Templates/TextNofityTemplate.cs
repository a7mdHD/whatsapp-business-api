namespace WhatsAppBusiness.Templates;

public class TextNofityTemplate(NotifyRequest request) : IBaseTemplate
{
    public Template CreateTemplate()
    {
        Template template = new Template
        {
            name = "notify",
            language = new Language(),
            components = new List<Component>
            {
                new Component
                {
                    type = "header",
                    parameters = new List<Parameter>
                    {
                        new Parameter {
                            text = request.Title
                        }
                    }
                },
                new Component
                {
                    type = "body",
                    parameters = new List<Parameter>
                    {
                        new Parameter {
                            text = request.Body
                        }
                    }
                }
            }
        };

        return template;
    }
}
