*Files to look at*:
* [WebForm1.aspx](./CS/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/WebForm1.aspx))
* [beforeRender.js](./CS/Scripts/beforeRender.js) (VB: [beforeRender.js](./VB/Scripts/beforeRender.js))

# ASPxDashboard - How to Enable Exporting in Data Inspector

This example demonstrates how to enable export to Excel in [Data Inspector](https://docs.devexpress.com/Dashboard/401194/common-features/underlying-and-displayed-data/data-inspector) (ASP.NET Web Forms). 

![](images/data_inspector_export.png)

Install and reference the [JSZip](https://stuk.github.io/jszip/) third-party library in your application to enable client-side export. Refer to the [DevExtreme Client-Side Exporting](https://js.devexpress.com/Documentation/Guide/Widgets/DataGrid/Client-Side_Exporting/) topic for more information.

Follow the steps below to enable export to Excel: 

1. Subscribe to the [BeforeRender](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_aspxclientdashboard_beforerender) event. 
2. Unregister [DataInspectorExtension](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension).
3. Register a new DataInspectorExtension instance with custom settings. Use the [onGridInitialized](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property to enable export in the Grid widget before its content is loaded.
4. Install and reference the [JSZip](https://stuk.github.io/jszip/) library.

API used in the example:

* The [BeforeRender](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_aspxclientdashboard_beforerender) event.
* The [DataInspectorExtension](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtension) class.
* The [DataInspectorExtensionOptions.onGridInitialized](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions#js_devexpress_dashboard_datainspectorextensionoptions_ongridinitialized) property.
* The [DashboardControlOptions.extensions](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DataInspectorExtensionOptions) property.



