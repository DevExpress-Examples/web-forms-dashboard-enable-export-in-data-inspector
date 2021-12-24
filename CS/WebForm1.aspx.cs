using System;
using System.Web.Hosting;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Web;

namespace Lesson3 {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            DashboardFileStorage newDashboardStorage = new DashboardFileStorage(HostingEnvironment.MapPath(@"~/App_Data/Dashboards"));
            ASPxDashboard1.SetDashboardStorage(newDashboardStorage);

            ASPxDashboard1.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();

            DashboardExtractDataSource extractDataSource = new DashboardExtractDataSource("Extract Data Source");
            extractDataSource.ConnectionName = "edsSales";
            dataSourceStorage.RegisterDataSource("extractDataSource", extractDataSource.SaveToXml());
            ASPxDashboard1.SetDataSourceStorage(dataSourceStorage);
        }

        protected void ASPxDashboard1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if (e.ConnectionName == "edsSales") {
                ExtractDataSourceConnectionParameters extractParams = new ExtractDataSourceConnectionParameters();
                extractParams.FileName = HostingEnvironment.MapPath(@"~/App_Data/SalesPersonExtract.dat");
                e.ConnectionParameters = extractParams;
            }
        }
    }
}