Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows.Forms

Public Class Form1
    'Dim cryRpt As New ReportDocument
    'Dim ds As frm1.DataSet = New frm1.DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'CrystalReportViewer1.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        'CrystalReportViewer1.DisplayToolbar = True
        'CrystalReportViewer1.ToolPanelView = True
        'CrystalReportViewer1.PrintReport()
        'CrystalReportViewer1.Refresh()
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim t As New DataTable

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Public Sub PreviewReport(tempCover As ReportDocument)
        'Dim tempCover = New ReportDocument
        Dim frm = New Form()
        Dim tempViewer = New CrystalReportViewer()
        tempViewer.ActiveViewIndex = -1
        tempViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        tempViewer.Dock = System.Windows.Forms.DockStyle.Fill
        tempViewer.Name = "tempViewer"
        tempViewer.SelectionFormula = ""
        tempViewer.TabIndex = 0
        tempViewer.ViewTimeSelectionFormula = ""

        tempViewer.ReportSource = tempCover

        tempViewer.AutoSize = True
        tempViewer.ToolPanelView = False
        tempViewer.DisplayToolbar = True
        tempViewer.Refresh()
        frm.Controls.Add(tempViewer)
        frm.AutoSize = True
        frm.ShowDialog()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cryRpt = New calenda
        'cryRpt.Load("C:\Users\bossd\Documents\Visual Studio 2015\Projects\YumaKuga\frm1\rep2.rpt")
        'cryRpt.SetParameterValue("Author", "DEMO")
        'cryRpt.SetDataSource(ds)
        Dim ds = New DataSet1
        Dim dt = ds.Tables("calenda")
        Dim today = Now
        For i = 0 To 90
            dt.Rows.Add(today.AddDays(i), 1, today.AddDays(i).DayOfWeek)
        Next
        cryRpt.Database.Tables("calenda").SetDataSource(dt)

        cryRpt.PrintOptions.PaperOrientation = PaperOrientation.Landscape
        Call PreviewReport(cryRpt)

        'cryRpt.PrintToPrinter(1, False, 0, 0)
    End Sub
End Class
