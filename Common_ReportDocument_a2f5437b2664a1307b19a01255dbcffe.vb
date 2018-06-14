
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Class Common_ReportDocument
    Inherits ReportDocument
    Dim ds As New frm2.DataSet1
    Public static_pathCR = Application.StartupPath.Replace("bin\Debug", "")
    Public nameCR As String

    Public Sub New(nameCR As String)
        Me.nameCR = nameCR
    End Sub

    Sub Print()
        Dim dialog1 As New PrintDialog()
        dialog1.AllowSomePages = True
        dialog1.AllowPrintToFile = False
        If (dialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Dim printSetings = dialog1.PrinterSettings
            Dim pageSettings = dialog1.PrinterSettings.DefaultPageSettings
            dialog1.Dispose()

            Dim oLayout = New CrystalDecisions.Shared.PrintLayoutSettings
            printSetings.Collate = True
            'Additional information: PrintScaling must be DoNotScale and Centered must be true when PrintOptions.DissociatePageSizeAndPrinterPaperSize is disabled.
            oLayout.Centered = True
            oLayout.Scaling = PrintLayoutSettings.PrintScaling.DoNotScale


            'PrintOptions.DissociatePageSizeAndPrinterPaperSize = True
            PrintOptions.PrinterName = dialog1.PrinterSettings.PrinterName
            'PrintToPrinter(copies, collate, fromPage, toPage,)
            PrintToPrinter(printSetings, pageSettings, False, oLayout)
        End If
    End Sub

    Public Sub Myload()
        Load(static_pathCR & "\" & nameCR & ".rpt")
    End Sub

    Public Sub SetDataTable(dtinput As DataTable)
        Dim dt = ds.Tables(nameCR)
        Select Case nameCR
            Case "calenda"
                dt.Rows.Add(Date.ParseExact("27/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("28/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("29/05/2018", "dd/MM/yyyy", Nothing), 1, "T2")
                dt.Rows.Add(Date.ParseExact("30/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("31/05/2018", "dd/MM/yyyy", Nothing), 0, "T2")

                Dim today = Date.ParseExact("01/06/2018", "dd/MM/yyyy", Nothing)
                For i = 0 To 30
                    dt.Rows.Add(today.AddDays(i), 1, "T2")
                Next
                dt.Rows.Add(Date.ParseExact("01/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("02/07/2018", "dd/MM/yyyy", Nothing), 1, "T2")
                dt.Rows.Add(Date.ParseExact("03/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("04/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("05/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("06/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")
                dt.Rows.Add(Date.ParseExact("07/07/2018", "dd/MM/yyyy", Nothing), 0, "T2")


                Dim txtdata As TextObject
                'Dim sectiondetail As Section
                'Dim line As LineObject

                txtdata = ReportDefinition.ReportObjects("txtMonth")
                'sectiondetail = cryRpt.ReportDefinition.Sections("Section3")
                'line = cryRpt.ReportDefinition.ReportObjects("Line6")
                txtdata.Text = "Sample Report By Using Data Table!!"

                SetParameterValue("fldMonth", "6")
            Case Else
                Dim a As String = "fff"

        End Select
        Me.Database.Tables(nameCR).SetDataSource(dt)
    End Sub
End Class

