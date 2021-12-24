<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="Lesson3.WebForm1" %>

<!DOCTYPE html>

<html>
<head runat="server">
	<title></title>
	<script src="Scripts/jszip.min.js"></script>
	<script src="Scripts/beforeRender.js"></script>
</head>
<body >
	<form id="form1" runat="server">
		<dx:ASPxDashboard ID="ASPxDashboard1" runat="server"
			ClientInstanceName="ASPxDashboard1"
			AllowInspectAggregatedData="true"
			AllowInspectRawData="true"
			IncludeDashboardIdToUrl="true"
			IncludeDashboardStateToUrl="true"
			OnConfigureDataConnection="ASPxDashboard1_ConfigureDataConnection"
			ClientSideEvents-BeforeRender="onBeforeRender">
		</dx:ASPxDashboard>
	</form>
</body>
</html>