Imports CrystalDecisions.Windows.Forms

Module Module1

    Sub Main()
        Dim str As String = "01000a00"
        Dim num As Int32
        Int32.TryParse(str, num)
        Console.WriteLine(String.Format("{0}", str))


        Dim crpt = New calenda
        Dim ds = New DataSet1
        Dim dt = ds.Tables("calenda")
        Dim today = Now
        For i = 0 To 90
            dt.Rows.Add(today.AddDays(i), 1, today.AddDays(i).DayOfWeek)
        Next


        Dim CrystalReportViewer1 = New CrystalReportViewer()
        crpt.Database.Tables("calenda").SetDataSource(dt)

        CrystalReportViewer1.ReportSource = crpt
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.Visible = True
        CrystalReportViewer1.Show()
        Console.ReadKey()
    End Sub

End Module
