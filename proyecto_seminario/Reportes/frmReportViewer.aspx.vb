Imports System.Data.SqlClient
Imports Microsoft.Reporting.WebForms

Public Class frmReportViewer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ReportViewer1.ProcessingMode = ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report.rdlc")
            Dim dsCustomers As Customers = GetData("select top 20 * from customers")
            Dim datasource As New ReportDataSource("Customers", dsCustomers.Tables(0))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(datasource)
        End If
    End Sub
    Private Function GetData(query As String) As Customers
        Dim conString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim cmd As New SqlCommand(query)
        Using con As New SqlConnection(conString)
            Using sda As New SqlDataAdapter()
                cmd.Connection = con

                sda.SelectCommand = cmd
                Using dsCustomers As New Customers()
                    sda.Fill(dsCustomers, "DataTable1")
                    Return dsCustomers
                End Using
            End Using
        End Using
    End Function


End Class