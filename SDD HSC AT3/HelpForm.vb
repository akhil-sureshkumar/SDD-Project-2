Public Class HelpForm
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Rtf = My.Resources.helpmenu
        RichTextBox1.ReadOnly = True
        Me.CenterToScreen()
    End Sub
End Class