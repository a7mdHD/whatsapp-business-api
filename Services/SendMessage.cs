using WhatsAppBusiness.Contracts;
using WhatsAppBusiness.Contracts.ReminderNotify;

namespace WhatsAppBusiness.Services;

public class SendMessage(IOptions<WhatsAppConfig> whatsAppConfig) : ISendMessage
{
    private readonly WhatsAppConfig _whatsAppConfig = whatsAppConfig.Value;

    public async Task<NotifyResponse> SendHelloWorld(HelloWorldRequest request, CancellationToken cancellationToken = default)
    {
        HelloWorldTemplate helloWorld = new();
        NotifyResponse response = new();
        WhatsAppRequestBody body = new WhatsAppRequestBody
        {
            to = "+2" + request.PhoneNumber,
            template = helloWorld.CreateTemplate()
        };

        try
        {
            response = await SendAsync(body, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return response;
    }

    public async Task<NotifyResponse> SendNotify(NotifyRequest request, CancellationToken cancellationToken = default)
    {
        NotifyResponse response = new();
        TextNofityTemplate textNofity = new(request);
        WhatsAppRequestBody body = new WhatsAppRequestBody
        {
            to = "+2" + request.PhoneNumber,
            template = textNofity.CreateTemplate()
        };

        try
        {
            response = await SendAsync(body, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return response;
    }

    public async Task<NotifyResponse> SendReminderNotify(ReminderNotifyRequest request, CancellationToken cancellationToken = default)
    {
        NotifyResponse response = new();
        ReminderNotifyTemplate reminderNotify = new(request);
        WhatsAppRequestBody body = new WhatsAppRequestBody
        {
            to = "+2" + request.PhoneNumber,
            template = reminderNotify.CreateTemplate()
        };

        try
        {
            response = await SendAsync(body, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return response;
    }

    public async Task<NotifyResponse> SendImageNotify(ImageNotifyRequest request, CancellationToken cancellationToken = default)
    {
        NotifyResponse response = new();
        ImageNotifyTemplate imageNotify = new(request);
        WhatsAppRequestBody body = new WhatsAppRequestBody
        {
            to = "+2" + request.PhoneNumber,
            template = imageNotify.CreateTemplate()
        };

        try
        {
            response = await SendAsync(body, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return response;
    }

    public async Task<NotifyResponse> SendDocNotify(DocNotifyRequest request, CancellationToken cancellationToken = default)
    {
        NotifyResponse response = new();
        DocNotifyTemplate docNotify = new(request);
        WhatsAppRequestBody body = new WhatsAppRequestBody
        {
            to = "+2" + request.PhoneNumber,
            template = docNotify.CreateTemplate()
        };

        try
        {
            response = await SendAsync(body, cancellationToken);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return response;
    }


    private async Task<NotifyResponse> SendAsync(WhatsAppRequestBody body, CancellationToken cancellationToken)
    {
        NotifyResponse notifyResponse = new();
        HttpClient httpClient = new();
        HttpResponseMessage httpResponseMessage = new();
        string apiUrl = _whatsAppConfig.WhatsAppApiUrl;
        string apiType = _whatsAppConfig.WhatsAppApiType;
        string apiKey = _whatsAppConfig.WhatsAppToken;

        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        HttpResponseMessage response = await httpClient.PostAsJsonAsync(apiUrl, body, cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            notifyResponse.Success = true;
            notifyResponse.Message = "Message sent successfully";
        }
        else
        {
            notifyResponse.Success = false;
            notifyResponse.Message = $"Error sending message: {response.ReasonPhrase}";
        }

        return notifyResponse;
    }
}
