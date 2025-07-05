namespace WhatsAppBusiness.Templates;

public class ImageNotifyTemplate(ImageNotifyRequest request) : IBaseTemplate
{
    public Template CreateTemplate()
    {
        Template template = new Template
        {
            name = "notify_with_image",
            language = new Language(),
            components = new List<Component>
            {
                new Component
                {
                    type = "header",
                    parameters = new List<Parameter>
                    {
                        new Parameter {
                            type = "image",
                            image = new Image
                            {
                                link = request.ImagePath
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
                            text = request.Body
                        }
                    }
                }
            }
        };

        return template;
    }
}
