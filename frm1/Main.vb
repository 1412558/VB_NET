Public Class Main

    Dim frm1 As Report = New Report
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm1.TabIndex = 0
        frm1.createPort(1)
        frm1.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm1.TabIndex = 0
        frm1.createPort(2)
        frm1.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm1.TabIndex = 0
        frm1.createPort(3)
        frm1.Show()
    End Sub
End Class