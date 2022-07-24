Public Class HomePage
    Private Sub Teacher_Click(sender As Object, e As EventArgs) Handles Student.Click
        Me.Hide()
        Call StudentInterface.ResetForm()
        StudentInterface.Show()
    End Sub
    Private Sub Student_Click(sender As Object, e As EventArgs) Handles Teacher.Click
        Me.Hide()
        GetText.Show()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HelpForm.Show()
    End Sub
End Class