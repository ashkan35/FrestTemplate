using System.Runtime.CompilerServices;
using Havit.Blazor.Components.Web.Bootstrap;
using Microsoft.AspNetCore.Components;

namespace FrestTemplate.Infra.Grid
{
    [CascadingTypeParameter(nameof(TItem))]

    public class DataGrid<TItem> : HxGrid<TItem>
    {
        public DataGrid()
        {
            TableCssClass = "table-bordered";
            PagerSettings = new PagerSettings
            {
                FirstPageIcon = BootstrapIcon.ArrowRightCircleFill,
                PreviousPageIcon = BootstrapIcon.ArrowRightCircle,
                NextPageIcon = BootstrapIcon.ArrowLeftCircle,
                LastPageIcon = BootstrapIcon.ArrowLeftCircleFill,
            };

        }

    }
}