using Microsoft.JSInterop;
using System.Numerics;

namespace FrestTemplate.Infra.JsServices.SweetAlert;

public class SweetAlertService : ISweetAlertService
{
    private readonly IJSRuntime _jSRuntime;

    public SweetAlertService(IJSRuntime jSRuntime)
    {
        _jSRuntime = jSRuntime;
        LoadScriptAndCss();
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

    private  Task LoadScriptAndCss()
    {
         _jSRuntime.InvokeVoidAsync("loadScript", "assets/vendor/libs/sweetalert2/sweetalert2.js");
         _jSRuntime.InvokeVoidAsync("loadLink", "assets/vendor/libs/sweetalert2/sweetalert2.css");
         return Task.CompletedTask;
    }
}

