namespace WhatsAppBusiness.Templates;

public class HelloWorldTemplate : IBaseTemplate
{
    public Template CreateTemplate()
    {
        Template template = new Template
        {
            name = "hello_world",
            language = new Language()
        };

        return template;
    }
}