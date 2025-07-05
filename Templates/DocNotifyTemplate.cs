namespace WhatsAppBusiness.Templates;

public class DocNotifyTemplate(DocNotifyRequest request) : IBaseTemplate
{
    public Template CreateTemplate()
    {
        Template template = new Template
        {
            name = "notify_with_doc",
            language = new Language(),
            components = new List<Component>
                {
                    new Component
                    {
                        type = "header",
                        parameters = new List<Parameter>
                        {
                            new Parameter {
                                type = "document",
                                document = new Document
                                {
                                    link = request.FilePath,
                                    filename = request.FileName
                                }
                            }
                        }
                    },
                    new Component
                    {
                        type = "body",
                        parameters = new List<Parameter>
                        {
                            new Parameter {
                                text = request.ReceiverName
                            },
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
