Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Public Class Form1

    Dim cryRpt As New ReportDocument
    Dim ds As New DataSet1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load



        Dim dt = ds.Tables("calenda")


        dt.Rows.Add(Date.ParseExact("27/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("28/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("29/05/2018", "dd/MM/yyyy", Nothing), 1, "T2")
        dt.Rows.Add(Date.ParseExact("30/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("31/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")

        Dim today = Date.ParseExact("01/06/2018", "dd/MM/yyyy", Nothing)
        For i = 0 To 29
            dt.Rows.Add(today.AddDays(i), 1, "T2")
        Next
        dt.Rows.Add(Date.ParseExact("01/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("02/07/2018", "dd/MM/yyyy", Nothing), 1, "T2")
        dt.Rows.Add(Date.ParseExact("03/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("04/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("05/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("06/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
        dt.Rows.Add(Date.ParseExact("07/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")




        cryRpt.Load(Application.StartupPath.Replace("bin\Debug", "") & "CrystalReport1.rpt")
        cryRpt.Database.Tables("calenda").SetDataSource(dt)
        'cryRpt.SetDataSource(dt3)

        'Dim txtdata As TextObject
        'Dim sectiondetail As Section
        'Dim line As LineObject

        'txtdata = cryRpt.ReportDefinition.ReportObjects("txtData")
        'sectiondetail = cryRpt.ReportDefinition.Sections("Section3")
        'line = cryRpt.ReportDefinition.ReportObjects("Line6")


        'txtdata.Text = "Sample Report By Using Data Table!!"





        cryRpt.VerifyDatabase()
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.DisplayToolbar = True
        CrystalReportViewer1.ToolPanelView = True
        ''CrystalReportViewer1.PrintReport()
        CrystalReportViewer1.Refresh()
    End Sub
End Class
