Public Class GetTestFile
    Dim ClozePassageWords() As String
    Dim OriginalText() As String
    Public WordBank() As String
    Public WordBankString As String
    Public BlankText As String
    Dim Valid As Boolean
    Dim wordbankarraysorter() As Integer
    Dim selectedtextcounter As Integer = 0
    Dim SelectedText As Boolean
    Dim tempwordbank() As String
    Dim temp1 As String
    Dim temp2 As String
#Region "UIElements"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()
    End Sub
    Private Sub BlankEverynWords_CheckedChanged(sender As Object, e As EventArgs) Handles BlankEverynWords.CheckedChanged
        ResetNewPassage.Hide()
        BlankNewPassage.Hide()
        If BlankEverynWords.Checked = True Then
            ReDim Preserve WordBank(0)
            WordBank(0) = Nothing
            GetWordBank.DataSource = Nothing
            WordBankString = Nothing
            'Resets all data to do with the WordBank
            If GetN.Text = "" Then
            ElseIf IsNumeric(GetN.Text) = True Then
                'Checks whether the value in the TextBox is a numeric value
                Call EveryNWords(Val(GetN.Text), ClozePassageWords, OriginalText, BlankText, WordBankString, Valid)
                If Valid = True Then
                    'Checks whether the number entered is valid given the amount of words in the original text
                    GetWordBank.Show()
                    ConfirmBlanks.Show()
                    Label4.Show()
                    BlankNewPassage.Hide()
                    ResetNewPassage.Hide()
                    GetBlankText.Text = BlankText
                    Call StringToWords(WordBankString, WordBank)
                    GetWordBank.DataSource = WordBank
                    'Shows the location of the blanks and the wordbank to the user
                    For i = 0 To (GetText.OriginalText.Length - 1)
                        ReDim Preserve OriginalText(i)
                        OriginalText(i) = GetText.OriginalText(i)
                    Next
                    ConfirmBlanks.Enabled = True
                Else
                    BlankNewPassage.Hide()
                    ResetNewPassage.Hide()
                    MsgBox("You have entered an invalid number, please try again.")
                End If
            End If
        End If
    End Sub
    Private Sub ManualBlanking_CheckedChanged(sender As Object, e As EventArgs) Handles ManualBlanking.CheckedChanged
        If ManualBlanking.Checked = True Then
            GetWordBank.Show()
            ConfirmBlanks.Enabled = True
            ConfirmBlanks.Show()
            Label4.Show()
            BlankNewPassage.Show()
            ResetNewPassage.Show()
            ReDim Preserve WordBank(0)
            WordBank(0) = ""
            selectedtextcounter = 0
            GetWordBank.DataSource = WordBank
            GetBlankText.Text = GetOriginalText.Text
        End If
    End Sub
    Private Sub BlankNewPassage_Click(sender As Object, e As EventArgs) Handles BlankNewPassage.Click
        SelectedText = True
        For i = 0 To (Len(GetBlankText.SelectedText) - 1)
            If GetBlankText.SelectedText(i) = " " OrElse GetBlankText.SelectedText(i) = "." OrElse GetBlankText.SelectedText(i) = "," OrElse GetBlankText.SelectedText(i) = ";" OrElse GetBlankText.SelectedText(i) = ":" OrElse GetBlankText.SelectedText(i) = "'" OrElse GetBlankText.SelectedText(i) = Chr(34) OrElse GetBlankText.SelectedText(i) = "!" OrElse GetBlankText.SelectedText(i) = "?" OrElse GetBlankText.SelectedText(i) = "(" OrElse GetBlankText.SelectedText(i) = ")" Then
                SelectedText = False
            End If
        Next
        If SelectedText = False Then
        Else
            SelectedText = False
            For i = 0 To (ClozePassageWords.Length - 1)
                If GetBlankText.SelectedText = ClozePassageWords(i) Then
                    SelectedText = True
                End If
            Next
        End If
        If SelectedText = True Then
            If selectedtextcounter = 0 Then
                Dim word As String = GetBlankText.SelectedText
                GetBlankText.SelectedText = "___________"
                ReDim Preserve WordBank(selectedtextcounter)
                WordBank(selectedtextcounter) = word
                GetWordBank.DataSource = WordBank
                selectedtextcounter = selectedtextcounter + 1
            Else
                Dim word As String = GetBlankText.SelectedText
                Dim value As Integer = GetBlankText.SelectionStart
                GetBlankText.SelectedText = "___________"
                Call LocationOfSpaces(GetBlankText.Text, wordbankarraysorter)
                ReDim Preserve WordBank(selectedtextcounter)
                WordBank(selectedtextcounter) = word
                For i = 0 To (wordbankarraysorter.Length - 1)
                    If value < wordbankarraysorter(i) Then
                        temp1 = WordBank(i - 1)
                        WordBank(i - 1) = word
                        If i = (wordbankarraysorter.Length - 1) Then
                            WordBank(i) = temp1
                        Else
                            For z = i To (wordbankarraysorter.Length - 1)
                                If z = (wordbankarraysorter.Length - 1) Then
                                    temp2 = WordBank(z)
                                    WordBank(z) = temp1
                                    value = wordbankarraysorter(i + 1)
                                Else
                                    temp2 = WordBank(z)
                                    WordBank(z) = temp1
                                    temp1 = temp2
                                End If
                            Next z
                        End If
                    End If
                Next
                GetWordBank.DataSource = Nothing
                GetWordBank.DataSource = WordBank
                selectedtextcounter = selectedtextcounter + 1
            End If
        Else
            MsgBox("You have not highlighted a valid word, try again.")
        End If
    End Sub
    Private Sub ResetNewPassage_Click(sender As Object, e As EventArgs) Handles ResetNewPassage.Click
        If GetOriginalText.Text = GetBlankText.Text Then
        Else
            If MsgBox("Are you sure you want to reset your cloze passage?", vbYesNo) = vbYes Then
                GetBlankText.Text = GetOriginalText.Text
                ReDim Preserve WordBank(0)
                WordBank(0) = ""
                selectedtextcounter = 0
                GetWordBank.DataSource = WordBank
            End If
        End If
        'Resets all blanks when user is doing manual blanking
    End Sub
    Private Sub ConfirmBlanks_Click(sender As Object, e As EventArgs) Handles ConfirmBlanks.Click
        Me.Hide()
        GetPreview.Show()
        Call GetPreview.Reset()
        'User confirms their selection of blanks and this is then stored in a file
    End Sub
#End Region
#Region "Functions"
    Sub Reset()
        Me.CenterToScreen()
        BlankNewPassage.Hide()
        ResetNewPassage.Hide()
        GetWordBank.Hide()
        ConfirmBlanks.Hide()
        Label4.Hide()
        ConfirmBlanks.Enabled = False
        GetN.Text = ""
        GetWordBank.DataSource = Nothing
        ClozePassageWords = Nothing
        OriginalText = Nothing
        WordBank = Nothing
        WordBankString = Nothing
        BlankText = Nothing
        Valid = Nothing
        wordbankarraysorter = Nothing
        GetOriginalText.Text = Nothing
        GetBlankText.Text = Nothing
        selectedtextcounter = 0
        SelectedText = Nothing
        GetOriginalText.Text = GetText.OriginalText
        Call StringToWords(GetText.OriginalText, ClozePassageWords)
        For i = 0 To (GetText.OriginalText.Length - 1)
            ReDim Preserve OriginalText(i)
            OriginalText(i) = GetText.OriginalText(i)
        Next
        'Stores the text obtained previously by user input in the form 'GetText' into a variable local to this form
    End Sub
    'Whenever this sub is called, all the variables and elements of the UI in the form are reset
    Sub StringToWords(ByVal Text As String, ByRef Words() As String)
        Dim NumberOfWords As Integer = 0
        Dim Temp As String = ""
        For i = 0 To (Len(Text) - 1)
            If Text(i) = " " OrElse Text(i) = "." OrElse Text(i) = "," OrElse Text(i) = ";" OrElse Text(i) = ":" OrElse Text(i) = "'" OrElse Text(i) = Chr(34) OrElse Text(i) = "!" OrElse Text(i) = "?" OrElse Text(i) = "(" OrElse Text(i) = ")" Then
                If Text(i - 1) = " " OrElse Text(i - 1) = "." OrElse Text(i - 1) = "," OrElse Text(i - 1) = ";" OrElse Text(i - 1) = ":" OrElse Text(i - 1) = "'" OrElse Text(i - 1) = Chr(34) OrElse Text(i - 1) = "!" OrElse Text(i - 1) = "?" OrElse Text(i - 1) = "(" OrElse Text(i - 1) = ")" Then
                Else
                    ReDim Preserve Words(NumberOfWords)
                    Words(NumberOfWords) = Temp
                    Temp = ""
                    NumberOfWords = NumberOfWords + 1
                End If
            ElseIf i = (Len(Text) - 1) Then
                Temp = Temp & Text(i)
                ReDim Preserve Words(NumberOfWords)
                Words(NumberOfWords) = Temp
                Temp = ""
            Else
                Temp = Temp & Text(i)
            End If
        Next i
        'Whenever this sub is called, it converts a string into an array of which each of its elements consist of the words within the string
    End Sub
    Sub EveryNWords(ByVal WordIncrement As Integer, ByVal Words() As String, ByVal Text() As String, ByRef GetBlankedText As String, ByRef GetWordBank As String, ByRef EveryNWordsValid As Boolean)
        EveryNWordsValid = False
        GetBlankedText = ""
        GetWordBank = ""
        Dim TextArray() As String = Text
        Dim n As Integer = 0
        If Words.Length >= WordIncrement Then
            GetWordBank = Words(WordIncrement - 1)
            Dim LowerWordBound As Integer = 0
            Dim UpperWordBound As Integer = 0
            For i = 0 To (Text.Length - 1)
                If Text(i) = " " OrElse Text(i) = "." OrElse Text(i) = "," OrElse Text(i) = ";" OrElse Text(i) = ":" OrElse Text(i) = "'" OrElse Text(i) = Chr(34) OrElse Text(i) = "!" OrElse Text(i) = "?" OrElse Text(i) = "(" OrElse Text(i) = ")" Then
                    If Text(i - 1) = " " OrElse Text(i - 1) = "." OrElse Text(i - 1) = "," OrElse Text(i - 1) = ";" OrElse Text(i - 1) = ":" OrElse Text(i - 1) = "'" OrElse Text(i - 1) = Chr(34) OrElse Text(i - 1) = "!" OrElse Text(i - 1) = "?" OrElse Text(i - 1) = "(" OrElse Text(i - 1) = ")" Then
                        LowerWordBound = i + 1
                    Else
                        If (n + 1) Mod WordIncrement = 0 Then
                            If n = WordIncrement - 1 Then
                            Else
                                GetWordBank = GetWordBank + " " + Words(n)
                            End If
                            n = n + 1
                            For z = LowerWordBound To UpperWordBound
                                TextArray(z) = ""
                            Next z
                            TextArray(LowerWordBound) = "___________"
                            LowerWordBound = i + 1
                        Else
                            n = n + 1
                            LowerWordBound = i + 1
                        End If
                    End If
                ElseIf i = (Text.Length - 1) Then
                    UpperWordBound = i
                    If (n + 1) Mod WordIncrement = 0 Then
                        If n = WordIncrement - 1 Then
                        Else
                            GetWordBank = GetWordBank + " " + Words(n)
                        End If
                        n = n + 1
                        For z = LowerWordBound To UpperWordBound
                            TextArray(z) = ""
                        Next z
                        TextArray(LowerWordBound) = "___________"
                        LowerWordBound = i + 1
                    Else
                        n = n + 1
                        LowerWordBound = i + 1
                    End If
                Else
                    UpperWordBound = i
                End If
            Next i
            GetBlankedText = ""
            For i = 0 To (TextArray.Length - 1)
                GetBlankedText = GetBlankedText + TextArray(i)
            Next i
            EveryNWordsValid = True
        End If
        'When this Sub is called, it returns the string with the blanks and also a string for the wordbank
    End Sub
    Sub ExportTestFile(ByRef text As String, ByRef valid As Boolean, ByRef blankedwords As String)
        valid = False
        SaveFileDialog1.InitialDirectory = "C:"
        SaveFileDialog1.ShowDialog()
        Dim filepath As String
        filepath = SaveFileDialog1.FileName
        If filepath = "" Then
        Else
            My.Computer.FileSystem.WriteAllText(filepath, text + "#lineseparator#" + Chr(10) + Chr(13) + blankedwords, True)
            valid = True
        End If
        'Opens a file dialog box which allows the user to save a .txt file
    End Sub
    Sub importfile(ByRef filepath As String, ByRef valid As Boolean)
        valid = False
        OpenFileDialog1.InitialDirectory = "C:"
        OpenFileDialog1.ShowDialog()
        filepath = OpenFileDialog1.FileName
        If filepath = "" Then
        Else
            valid = True
        End If
        'Opens a file dialog box and stores the filepath of the file selected
    End Sub
    Sub LocationOfSpaces(ByRef text As String, ByRef index() As Integer)
        Dim n As Integer = 0
        For i = 0 To (text.Length - 1)
            If text(i) = "_" Then
                ReDim Preserve index(n)
                index(n) = i
                n = n + 1
                i = i + 10
            End If
        Next
    End Sub
    'When this sub is called, it returns an array with the values for the locations of spaces in the corresponding array element
#End Region
End Class