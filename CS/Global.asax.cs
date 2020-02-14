using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Security;
using System.Web.SessionState;

namespace Lesson3
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //DashboardFileStorage newDashboardStorage = new DashboardFileStorage(@"~/App_Data/Dashboards");
            // DashboardConfigurator.Default.SetDashboardStorage(newDashboardStorage);


            ////sqlDataSource.DataProcessingMode = DataProcessingMode.Client;

            //DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            //DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);
            //DashboardConfigurator.Default.ConfigureDataConnection += DataApi_ConfigureDataConnection;
            //DashboardConfigurator.Default.AllowExecutingCustomSql = true;
            //DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());




        }

        void DataApi_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e)
        {
            //if (e.DataSourceName == "SQL Data Source")
            //{
            //    Access97ConnectionParameters connectionParams = new Access97ConnectionParameters();
            //    connectionParams.FileName = HostingEnvironment.MapPath(@"~/App_Data/nwind.mdb");
            //    e.ConnectionParameters = connectionParams;
            //}

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}