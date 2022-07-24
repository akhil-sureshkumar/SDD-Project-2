Public Class GetPreview
    Dim Valid As Boolean
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call GetTestFile.ExportTestFile(GetTestFile.BlankText, Valid, GetTestFile.WordBankString)
        If Valid = True Then
            Me.Reset()
            Me.Hide()
            HomePage.Show()
            Call GetText.Reset()
        End If
    End Sub
    Sub Reset()
        GetBlankText.Text = ""
        GetWordBank.DataSource = Nothing
        GetBlankText.Text = GetTestFile.GetBlankText.Text
        GetWordBank.DataSource = GetTestFile.WordBank
        Valid = False
        If MsgBox("Do you want to print your cloze passage?", vbYesNo) = vbYes Then
            PrintDialog1.ShowDialog()
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printerfont As New Font("calibri", 12, FontStyle.Regular)
        e.Graphics.DrawString("Word Bank: " + GetTestFile.WordBankString + Chr(10) + Chr(13) + GetTestFile.BlankText, printerfont, Brushes.Black, 100, 100)
    End Sub
End Class