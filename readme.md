<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/240536881/23.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T862387)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for Web Forms - How to Enable Export in Data Inspector

This example demonstrates how to enable export to Excel in [Data Inspector](https://docs.devexpress.com/Dashboard/401194/common-features/underlying-and-displayed-data/data-inspector). 

![](images/data_inspector_export.png)

Follow the steps below to enable export to Excel:

1. Install and reference the additional third-party library required for client-side export. Refer to the following topic for more information: [DevExtreme Client-Side Export](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/Configuration/export/).
1. Subscribe to the [`BeforeRender`](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Web.WebForms.ASPxClientDashboard?p=netframework#js_aspxclientdashboard_beforerender) event. 
1. Call the [`DashboardControl.option`](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl?p=netframework#js_devexpress_dashboard_dashboardcontrol_option_args_) method and get access to the [`DataInspectorExtension`](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension) options.
1. Use the [`DataInspectorExtensionOptions.onGridInitialized`](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property to enable export in the Grid widget before its content is loaded.


<!-- default file list -->
## Files to Look At
* [WebForm1.aspx](./CS/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/WebForm1.aspx))
* [beforeRender.js](./CS/Scripts/beforeRender.js) (VB: [beforeRender.js](./VB/Scripts/beforeRender.js))
<!-- default file list end -->

## Documentation

* [Manage Data Inspector in the ASP.NET Web Forms Dashboard Control](https://docs.devexpress.com/Dashboard/403976/web-dashboard/aspnet-web-forms-dashboard-control/manage-data-inspector-in-asp-net-web-forms-dashboard-control)
* [Client-Side API Overview for ASP.NET Web Forms Dashboard](https://docs.devexpress.com/Dashboard/116302/web-dashboard/aspnet-web-forms-dashboard-control/client-side-api-overview)

## API

* The [ASPxClientDashboard.BeforeRender](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Web.WebForms.ASPxClientDashboard?p=netframework#js_aspxclientdashboard_beforerender) event.
* The [DashboardControl.option](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl?p=netframework#js_devexpress_dashboard_dashboardcontrol_option_args_) method.
* The [DashboardControlOptions.extensions](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions) property.
* The [DataInspectorExtension](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension) class.
* The [DataInspectorExtensionOptions.onGridInitialized](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property.

## More Examples

- [Dashboard for MVC - How to Enable Export in Data Inspector](https://github.com/DevExpress-Examples/asp.net-mvc-dashboard-how-to-enable-export-in-data-inspector)
- [Dashboard for Web Forms - How to export Web Dashboard into PDF with different filter values on different pages](https://github.com/DevExpress-Examples/how-to-export-web-dashboard-into-pdf-with-different-filter-values-on-different-pages-t511362)
