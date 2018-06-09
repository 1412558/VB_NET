Imports CrystalDecisions.CrystalReports.Engine

Public Class Report
    Dim cryRpt As New ReportDocument
    Dim ds As frm1.DataSet = New frm1.DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Width = 1024
        Me.Height = 768
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    End Sub
    Public Sub createPort(ByVal type As Integer)
        If type = 1 Then
            Dim dt1 As DataTable = ds.Tables("Student")
            dt1.Clear()
            dt1.Rows.Add(1, 11, 111, "sf", "06/06/2018")
            dt1.Rows.Add(2, 22, 222, "sdf", "06/06/2018")
            dt1.Rows.Add(3, 33, 333, "sdf", "06/06/2018")
            dt1.Rows.Add(5, 55, 555, "sf", "06/06/2018")
            dt1.Rows.Add(6, 66, 666, "aa", "06/06/2018")
            dt1.Rows.Add(7, 77, 777, "2", "06/06/2018")
            dt1.Rows.Add(8, 88, 888, "d", "06/06/2018")

            cryRpt.Load("C:\Users\bossd\Documents\Visual Studio 2015\Projects\YumaKuga\frm1\rep1.rpt")
            cryRpt.SetDataSource(dt1)
            'cryRpt.VerifyDatabase()

        End If

        If type = 2 Then
            Dim dt2 As DataTable = ds.Tables("Subject")
            dt2.Clear()
            dt2.Rows.Add("1", "A", 10)
            dt2.Rows.Add("2", "B", 20)
            dt2.Rows.Add("3", "C", 30)
            dt2.Rows.Add("4", "D", 40)
            dt2.Rows.Add("5", "E", 50)


            cryRpt.Load("C:\Users\bossd\Documents\Visual Studio 2015\Projects\YumaKuga\frm1\rep2.rpt")
            'cryRpt.SetParameterValue("Author", "DEMO")
            cryRpt.SetDataSource(ds)

            'cryRpt.VerifyDatabase()
        End If

        If type = 3 Then
            Dim dt3 As DataTable = ds.Tables("Bill")
            dt3.Clear()
            dt3.Rows.Add("1", Now, 10, "A")
            dt3.Rows.Add("2", Now, 20, "A")
            dt3.Rows.Add("3", Now, 30, "A")
            dt3.Rows.Add("4", Now, 40, "A")
            dt3.Rows.Add("5", Now, 50, "A")


            cryRpt.Load("C:\Users\bossd\Documents\Visual Studio 2015\Projects\YumaKuga\frm1\rep3.rpt")

            cryRpt.Database.Tables("Bill").SetDataSource(dt3)
            'cryRpt.SetDataSource(dt3)

            Dim root As TextObject

            root = cryRpt.ReportDefinition.ReportObjects("txtData")

            cryRpt.VerifyDatabase()
            root.Text = "Sample Report By Using Data Table!!"
            'cryRpt.VerifyDatabase()
        End If


        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.DisplayToolbar = True
        CrystalReportViewer1.ToolPanelView = True
        ''CrystalReportViewer1.PrintReport()
        CrystalReportViewer1.Refresh()
    End Sub

End Class