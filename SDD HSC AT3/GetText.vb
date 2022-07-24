Public Class GetText
    Dim FilePathValid As Boolean
    Dim FilePath As String
    Public OriginalText As String
    Private Sub GetText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()
    End Sub
    Private Sub NextStep_Click(sender As Object, e As EventArgs) Handles NextStep.Click
        If TypeText.Text = "" Then
            MsgBox("The text field is empty, please try again.")
        Else
            OriginalText = TypeText.Text
            Me.Hide()
            GetTestFile.Show()
            Call GetTestFile.Reset()
            'Goes to the next form in which the user chooses how to blank out their passage
        End If
    End Sub
    Private Sub GetFilePath_Click(sender As Object, e As EventArgs) Handles GetFilePath.Click
        Call GetTestFile.importfile(FilePath, FilePathValid)
        'This is a sub called from Form1 which will return the filepath of the file the user selected in the string 'FilePath'
        If FilePathValid = True Then
            TypeText.Text = ""
            TypeText.Text = My.Computer.FileSystem.ReadAllText(FilePath)
            FilePathValid = False
            'This is a flag used to check that a valid filepath has been selected to prevent a crash from occuring
        End If
    End Sub
    Sub Reset()
        Me.CenterToScreen()
        OriginalText = Nothing
        FilePath = Nothing
        TypeText.Text = Nothing
        Text = Nothing
        'Whenever this sub is called, all the variables and elements of the UI in the form are reset
    End Sub

    Private Sub TypeText_TextChanged(sender As Object, e As EventArgs) Handles TypeText.TextChanged

    End Sub
End Class