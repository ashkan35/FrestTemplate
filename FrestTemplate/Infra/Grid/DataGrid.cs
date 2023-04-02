using System.Runtime.CompilerServices;
using Havit.Blazor.Components.Web.Bootstrap;
using Microsoft.AspNetCore.Components;

namespace FrestTemplate.Infra.Grid
{
    [CascadingTypeParameter(nameof(TItem))]

    public class DataGrid<TItem> : HxGrid<TItem>
    {
        //This code sets the TableCssClass property of the DataGrid object to "table-bordered" and sets the PagerSettings property to a new PagerSettings object with the following properties: FirstPageIcon, PreviousPageIcon, NextPageIcon, and LastPageIcon. 
        public DataGrid()
        {
            //Set the TableCssClass property of the DataGrid object to "table-bordered"
            TableCssClass = "table-bordered";
            //Set the PagerSettings property to a new PagerSettings object
            PagerSettings = new PagerSettings
            {
                //Set the FirstPageIcon property to BootstrapIcon.ArrowRightCircleFill
                FirstPageIcon = BootstrapIcon.ArrowRightCircleFill,
                //Set the PreviousPageIcon property to BootstrapIcon.ArrowRightCircle
                PreviousPageIcon = BootstrapIcon.ArrowRightCircle,
                //Set the NextPageIcon property to BootstrapIcon.ArrowLeftCircle
                NextPageIcon = BootstrapIcon.ArrowLeftCircle,
                //Set the LastPageIcon property to BootstrapIcon.ArrowLeftCircleFill
                LastPageIcon = BootstrapIcon.ArrowLeftCircleFill,
            };

        }

    }
}