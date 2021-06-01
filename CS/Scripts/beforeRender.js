function onBeforeRender(sender) {
    var dashboardControl = sender.GetDashboardControl();
    dashboardControl.option({
        extensions: {
            dataInspector: {
                onGridInitialized
            }
        }
    })
}
function onGridInitialized(e) {
    e.component.option({
        export: {
            enabled: true
        }
    })
}