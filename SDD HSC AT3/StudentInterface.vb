Public Class StudentInterface
    Dim FilePath As String
    Dim ValidFilePath As Boolean
    Dim LineSeparatorFound As Boolean = False
    Dim TempString As String
    Dim LowerSeparator As Integer
    Dim UpperSeparator As Integer
    Public BlankText As String
    Dim WordBankString As String
    Dim WordBank() As String
    Dim JumbledWordBank() As String
    Dim BlankTextArray() As String
    Dim Reset() As String
    Dim Unselected() As String
    Dim Selected() As String
    Dim BlankCount As Integer = 1
    Dim tempwordbank() As String
    Dim testdone As Boolean
    Dim alreadyblankedarray() As Integer
    Dim k As Integer = 0
    Public mark As Integer = 0
    Public correct() As String
    Public incorrect As String
#Region "UI Elements"
    Private Sub GetFilePath_Click(sender As Object, e As EventArgs) Handles GetFilePath.Click
        Call GetTestFile.importfile(FilePath, ValidFilePath)
        If ValidFilePath = False Then
        Else
            TempString = ""
            TempString = My.Computer.FileSystem.ReadAllText(FilePath)
            For i = 0 To (Len(TempString) - 1)
                If TempString(i) = "#" Then
                    If TempString(i + 1) = "l" Then
                        If TempString(i + 2) = "i" Then
                            If TempString(i + 3) = "n" Then
                                If TempString(i + 4) = "e" Then
                                    If TempString(i + 5) = "s" Then
                                        If TempString(i + 6) = "e" Then
                                            If TempString(i + 7) = "p" Then
                                                If TempString(i + 8) = "a" Then
                                                    If TempString(i + 9) = "r" Then
                                                        If TempString(i + 10) = "a" Then
                                                            If TempString(i + 11) = "t" Then
                                                                If TempString(i + 12) = "o" Then
                                                                    If TempString(i + 13) = "r" Then
                                                                        If TempString(i + 14) = "#" Then
                                                                            LowerSeparator = i - 1
                                                                            UpperSeparator = i + 15
                                                                            LineSeparatorFound = True
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            'The following code is used to separate the string from the text file into the cloze passage and the wordbank by finding the lineseparator
            If LineSeparatorFound = True Then
                BlankText = ""
                For i = 0 To LowerSeparator
                    BlankText = BlankText + TempString(i)
                Next
                'Loads the Cloze Passage into a string
                WordBankString = ""
                For i = UpperSeparator To (Len(TempString) - 1)
                    WordBankString = WordBankString + TempString(i)
                Next
                'Loads the wordbank into a string
                Dim Temp1 As String = WordBankString.Replace(vbLf, "")
                Dim Temp2 As String = Temp1.Replace(vbCr, "")
                'Gets rid of characters vbLf and vbCr from the wordbank to prevent any syntax errors occuring
                Call GetTestFile.StringToWords(Temp2, WordBank)
                'Converts the wordbank string into an array
                For i = 0 To (WordBank.Length - 1)
                    ReDim Preserve JumbledWordBank(i)
                    JumbledWordBank(i) = WordBank(i)
                Next
                Call RandomizeArray(JumbledWordBank)
                GetWordBank.DataSource = JumbledWordBank
                'Stores the wordbank in another array then jumbles that array and displays it
                For i = 0 To (Len(BlankText) - 1)
                    ReDim Preserve BlankTextArray(i)
                    BlankTextArray(i) = BlankText(i)
                Next
                BlankCount = 1
                For i = 0 To (BlankTextArray.Length - 1)
                    If BlankTextArray(i) = "_" Then
                        BlankTextArray(i) = "(" & CStr(BlankCount) & ")_"
                        BlankCount = BlankCount + 1
                        i = i + 10
                    End If
                Next
                'Stores each of the characters of the Cloze Passage into an array and identifies each blank in ascending order with a number
                GetBlankText.Text = ""
                For i = 0 To (BlankTextArray.Length - 1)
                    GetBlankText.Text = GetBlankText.Text + BlankTextArray(i)
                Next
                'Displays the Cloze passage with the blanks and the number identifiers
                StartClozeTest.Show()
                GetBlankText.Show()
                GetWordBank.Show()
                Label1.Show()
                GetFilePath.Hide()
            Else
                MsgBox("The File you have opened is invalid, please try again.")
            End If
        End If
    End Sub
    Private Sub StartClozeTest_Click(sender As Object, e As EventArgs) Handles StartClozeTest.Click
        For i = 0 To (BlankTextArray.Length - 1)
            ReDim Preserve Reset(i)
            Reset(i) = BlankTextArray(i)
        Next
        For i = 0 To (JumbledWordBank.Length - 1)
            ReDim Preserve Unselected(i)
            Unselected(i) = JumbledWordBank(i)
        Next
        ReDim Preserve Selected(WordBank.Length - 1)
        GroupBox1.Show()
        GetBlankNumber.Maximum = WordBank.Length
        GetBlankNumber.Minimum = 1
        StartClozeTest.Hide()
        ResetClozeTest.Show()
    End Sub
    Private Sub StudentInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ResetForm()
    End Sub
    Private Sub GetAnswer_Click(sender As Object, e As EventArgs) Handles GetAnswer.Click
        Dim blanknumbervalid As Boolean = True
        If GetWordBank.SelectedItem = "" Then
            MsgBox("You cannot choose a blank word, please try again.")
            blanknumbervalid = False
            'Checks that the user isn't selecting a blank element from the wordbank
        Else
            If k = 0 Then

            Else
                For n = 0 To (k - 1)
                    If GetBlankNumber.Value = alreadyblankedarray(n) Then
                        MsgBox("You have already chosen a word for this blank space, please try again.")
                        blanknumbervalid = False
                    End If
                Next
            End If
        End If
        'Blanks out the underscores and the number identifier of the blank number selected by the user and replaces it with the word they have selected from the wordbank
        If blanknumbervalid = True Then
            For i = 0 To (BlankTextArray.Length - 1)
                If BlankTextArray(i) = "(" & CStr(GetBlankNumber.Value) & ")_" Then
                    BlankTextArray(i) = GetWordBank.SelectedItem
                    For z = (i + 1) To (i + 10)
                        BlankTextArray(z) = ""
                    Next
                End If
            Next
            Dim tempstring As String = Join(BlankTextArray, "")
            GetBlankText.Text = tempstring
            Selected(GetBlankNumber.Value - 1) = GetWordBank.SelectedItem
            Unselected(GetWordBank.SelectedIndex) = ""
            GetWordBank.DataSource = Nothing
            GetWordBank.DataSource = Unselected
            ReDim Preserve alreadyblankedarray(k)
            alreadyblankedarray(k) = GetBlankNumber.Value
            k += 1
            'Stores the word the student has selected in the array element with the index being the blank number chosen and blanks out the word they have chosen from the wordbank
            For i = 0 To (Selected.Length - 1)
                If Selected(i) = "" Then
                    testdone = False
                Else
                    testdone = True
                End If
            Next
            'Checks whether the user has completed the cloze test
            If testdone = True Then
                Dim temp1 As String = WordBankString.Replace(vbLf, "")
                Dim temp2 As String = temp1.Replace(vbCr, "")
                ReDim correct(WordBank.Length - 1)
                tempwordbank = Nothing
                Call GetTestFile.StringToWords(temp2, tempwordbank)
                For i = 0 To (WordBank.Length - 1)
                    If Selected(i) = tempwordbank(i) Then
                        mark = mark + 1
                        correct(i) = Selected(i)
                    Else
                        incorrect = incorrect + Selected(i) + ", "
                    End If
                Next
                MsgBox("You got " + CStr(mark) + " correct out of " + CStr(WordBank.Length) + "! You got the following words wrong: " + incorrect)
                Me.Hide()
                HomePage.Show()
            End If
            'Shows the student their mark if they have finished the test
            If GetBlankNumber.Value < GetBlankNumber.Maximum Then
                GetBlankNumber.Value = GetBlankNumber.Value + 1
            End If
        End If
    End Sub
    Private Sub ResetClozetest_Click(sender As Object, e As EventArgs) Handles ResetClozeTest.Click
        ReDim Selected(WordBank.Length - 1)
        For i = 0 To (BlankTextArray.Length - 1)
            BlankTextArray(i) = Reset(i)
        Next
        Dim tempstring As String = Join(BlankTextArray, "")
        GetBlankText.Text = tempstring
        For i = 0 To (JumbledWordBank.Length - 1)
            ReDim Preserve Unselected(i)
            Unselected(i) = JumbledWordBank(i)
        Next
        GetWordBank.DataSource = JumbledWordBank
        ReDim Preserve Selected(WordBank.Length - 1)
        GroupBox1.Show()
        GetBlankNumber.Maximum = WordBank.Length
        GetBlankNumber.Minimum = 1
        StartClozeTest.Hide()
        ResetClozeTest.Show()
        GetBlankNumber.Value = 1
        mark = 0
        'Resets everything to do with the cloze test if the user decides they want to redo it
    End Sub
#End Region
#Region "Functions"
    Sub RandomizeArray(ByVal Array() As String)
        Dim max_index As Integer = Array.Length - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            Dim j As Integer = rnd.Next(i, max_index + 1)
            Dim temp As String = Array(i)
            Array(i) = Array(j)
            Array(j) = temp
        Next i
        'Following code is from http://www.vb-helper.com/howto_net_randomize_array.html
        'When this sub is called, all the elements in an array are randomized
    End Sub
    Sub ResetForm()
        Me.CenterToScreen()
        GetFilePath.Show()
        GroupBox1.Hide()
        GetBlankText.Hide()
        StartClozeTest.Hide()
        ResetClozeTest.Hide()
        GetWordBank.Hide()
        Label1.Hide()
        GetBlankNumber.Value = 1
        FilePath = Nothing
        TempString = Nothing
        LineSeparatorFound = False
        LowerSeparator = Nothing
        UpperSeparator = Nothing
        BlankText = Nothing
        WordBankString = Nothing
        WordBank = Nothing
        JumbledWordBank = Nothing
        BlankTextArray = Nothing
        Reset = Nothing
        Unselected = Nothing
        Selected = Nothing
        BlankCount = Nothing
        tempwordbank = Nothing
        testdone = Nothing
        alreadyblankedarray = Nothing
        'Whenever this sub is called, all the variables and elements of the UI in the form are reset
    End Sub
#End Region
End Class