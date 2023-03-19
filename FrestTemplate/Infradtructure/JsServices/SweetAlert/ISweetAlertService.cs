namespace FrestTemplate.Infradtructure.JsServices.SweetAlert;

public interface ISweetAlertService
{
    Task NotificationWithButton(SweetAlertType type, string text);
}

