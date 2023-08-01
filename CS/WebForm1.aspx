<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lesson3.WebForm1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/babel-polyfill/7.12.1/polyfill.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/exceljs/3.8.0/exceljs.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/FileSaver.js/2.0.5/FileSaver.min.js"></script>
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