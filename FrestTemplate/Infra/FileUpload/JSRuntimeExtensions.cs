using System.Diagnostics.Contracts;
using System.Reflection;
using Havit.Blazor.Components.Web;
using Microsoft.JSInterop;

namespace FrestTemplate.Infra.FileUpload;
public static class JsRuntimeExtensions
{
    public static ValueTask<IJSObjectReference> ImportModuleAsync(this IJSRuntime jsRuntime, string modulePath, Assembly assemblyForVersionInfo = null)
    {
        Contract.Requires<ArgumentException>(!string.IsNullOrWhiteSpace(modulePath));

        if (assemblyForVersionInfo is not null)
        {
            modulePath = modulePath + "?v=" + GetAssemblyVersionIdentifierForUri(assemblyForVersionInfo);
        }
        return jsRuntime.InvokeAsync<IJSObjectReference>("import", modulePath);
    }

    internal static ValueTask<IJSObjectReference> ImportHavitBlazorWebModuleAsync(this IJSRuntime jsRuntime, string moduleNameWithoutExtension)
    {
        var path = "/Js/" + moduleNameWithoutExtension + ".js";
        return jsRuntime.InvokeAsync<IJSObjectReference>("import", path);
    }
    private static string versionIdentifierHavitBlazorWeb;

    internal static string GetAssemblyVersionIdentifierForUri(Assembly assembly)
    {
        return Uri.EscapeDataString(((AssemblyInformationalVersionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyInformationalVersionAttribute), false)).InformationalVersion);
    }
}
