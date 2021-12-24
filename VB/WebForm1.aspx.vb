Imports System
Imports System.Web.Hosting
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.Web

Namespace Lesson3
	Partial Public Class WebForm1
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim newDashboardStorage As New DashboardFileStorage(HostingEnvironment.MapPath("~/App_Data/Dashboards"))
			ASPxDashboard1.SetDashboardStorage(newDashboardStorage)

			ASPxDashboard1.SetConnectionStringsProvider(New ConfigFileConnectionStringsProvider())
			Dim dataSourceStorage As New DataSourceInMemoryStorage()

			Dim extractDataSource As New DashboardExtractDataSource("Extract Data Source")
			extractDataSource.ConnectionName = "edsSales"
			dataSourceStorage.RegisterDataSource("extractDataSource", extractDataSource.SaveToXml())
			ASPxDashboard1.SetDataSourceStorage(dataSourceStorage)
		End Sub

		Protected Sub ASPxDashboard1_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			If e.ConnectionName = "edsSales" Then
				Dim extractParams As New ExtractDataSourceConnectionParameters()
				extractParams.FileName = HostingEnvironment.MapPath("~/App_Data/SalesPersonExtract.dat")
				e.ConnectionParameters = extractParams
			End If
		End Sub
	End Class
End Namespace