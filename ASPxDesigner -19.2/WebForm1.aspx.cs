using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Web;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxDashboard1.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
        }

        protected void ASPxDashboard1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e)
        {
            if (e.ConnectionName == "nwindAccess")
            {
                Access97ConnectionParameters param = new Access97ConnectionParameters();
                param.FileName = Server.MapPath("~/App_Data/nwind.mdb");
                e.ConnectionParameters = param;
            }
        }
    }
}