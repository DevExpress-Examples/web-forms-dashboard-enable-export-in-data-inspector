<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="Lesson3.WebForm1" %>

<%@ Register assembly="DevExpress.Dashboard.v19.2.Web.WebForms, Version=19.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.DashboardWeb" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v19.2, Version=19.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Dashboard.v19.2.Web.WebForms, Version=19.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.DashboardWeb" tagprefix="dx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<script src="../Scripts/jszip.min.js"></script>
	<script src="../Scripts/beforeRender.js"></script>
</head>
<body >
	<form id="form1" runat="server">
	<dx:ASPxDashboard ID="ASPxDashboard1" runat="server"
		ClientInstanceName="ASPxDashboard1"
		AllowInspectAggregatedData="true"
		AllowInspectRawData="true"
					IncludeDashboardIdToUrl = "True"
					IncludeDashboardStateToUrl = "True"
		OnConfigureDataConnection="ASPxDashboard1_ConfigureDataConnection"
		ClientSideEvents-BeforeRender="onBeforeRender">
			</dx:ASPxDashboard>
	</form>
</body>
</html>