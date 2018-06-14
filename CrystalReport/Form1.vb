Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource



Public Class Form1
    'Dim cryRpt As New ReportDocument
    'Dim ds As frm1.DataSet = New frm1.DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cryRpt.Load("C:\Users\bossd\Documents\Visual Studio 2015\Projects\YumaKuga\frm1\rep2.rpt")
        'cryRpt.SetParameterValue("Author", "DEMO")
        'cryRpt.SetDataSource(ds)

        'cryRpt.VerifyDatabase()
        'CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.DisplayToolbar = True
        'CrystalReportViewer1.ToolPanelView = True
        'CrystalReportViewer1.PrintReport()
        'CrystalReportViewer1.Refresh()
        Me.Width = 400
        Me.Height = 400
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cryRpt = New Common_ReportDocument("calenda")
        Dim t As New DataTable
        cryRpt.Myload()
        cryRpt.SetDataTable(t)
        cryRpt.Print()
        cryRpt.Dispose()
    End Sub
End Class
