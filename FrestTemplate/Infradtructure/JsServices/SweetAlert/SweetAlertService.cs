using Microsoft.JSInterop;

namespace FrestTemplate.Infradtructure.JsServices.SweetAlert;

public class SweetAlertService : ISweetAlertService
{
    private readonly IJSRuntime _jSRuntime;

    public SweetAlertService(IJSRuntime jSRuntime)
    {
        _jSRuntime = jSRuntime;
    }
    public Task NotificationWithButton(SweetAlertType type, string text)
    {
        if (type == SweetAlertType.Error)
        {
            
            _jSRuntime.InvokeVoidAsync("SwalFire", new string[] { "error", "خطا!", text, "btn btn-primary", "باشه" });
           
        }
        if (type == SweetAlertType.Warning)
        {
            _jSRuntime.InvokeVoidAsync("SwalFire", new string[] { "warning", "هشدار!", text, "btn btn-primary", "باشه" });
        }
        if (type == SweetAlertType.Success)
        {
            _jSRuntime.InvokeVoidAsync("SwalFire", new string[] { "success", "عملیات موفق!", text, "btn btn-primary", "باشه" });
        }
        if (type == SweetAlertType.Info)
        {
            _jSRuntime.InvokeVoidAsync("SwalFire", new string[] { "info", "پیام سیستم", text, "btn btn-primary", "باشه" });
        }
        if (type == SweetAlertType.Question)
        {
            _jSRuntime.InvokeVoidAsync("SwalFire", new string[] { "question", "سوال", text, "btn btn-primary", "باشه" });
        }
        return Task.CompletedTask;
        
    }
}

