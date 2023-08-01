function onBeforeRender(sender) {
    var dashboardControl = sender.GetDashboardControl();
    dashboardControl.option({
        extensions: {
            dataInspector: {
                onGridInitialized
            }
        }
    });
}
function onGridInitialized(e) {
    e.component.option({
        export: {
            enabled: true
        },
        onExporting() {
            const workbook = new ExcelJS.Workbook();
            const worksheet = workbook.addWorksheet('Main sheet');

            DevExpress.excelExporter.exportDataGrid({
                component: e.component,
                worksheet: worksheet
            }).then(function () {
                workbook.xlsx.writeBuffer().then(function (buffer) {
                    saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'DataGrid.xlsx');
                });
            });
        }
    });
}