namespace FrestTemplate.Infra.JsServices.SweetAlert;

public interface ISweetAlertService
{
    Task NotificationWithButton(SweetAlertType type, string text);
}

