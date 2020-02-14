function onBeforeRender(sender) {
    var control = sender.GetDashboardControl();
    control.unregisterExtension('data-inspector');
    control.registerExtension(new DevExpress.Dashboard.DataInspectorExtension(control, {
        allowInspectAggregatedData: true,
        allowInspectRawData: true,
        onGridInitialized: function (args) {
            args.component.option({
                export: { enabled: true }
            })
        }
    }));
}