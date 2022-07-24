<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GetTestFile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GetN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BlankEverynWords = New System.Windows.Forms.RadioButton()
        Me.ManualBlanking = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConfirmBlanks = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GetOriginalText = New System.Windows.Forms.TextBox()
        Me.GetWordBank = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BlankNewPassage = New System.Windows.Forms.Button()
        Me.ResetNewPassage = New System.Windows.Forms.Button()
        Me.GetBlankText = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.Filter = "Text file|*.txt; *.docx"
        Me.OpenFileDialog1.InitialDirectory = "Application"
        Me.OpenFileDialog1.Title = "Open text file"
        '
        'GetN
        '
        Me.GetN.Location = New System.Drawing.Point(121, 12)
        Me.GetN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GetN.Name = "GetN"
        Me.GetN.Size = New System.Drawing.Size(23, 22)
        Me.GetN.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "words"
        '
        'BlankEverynWords
        '
        Me.BlankEverynWords.AutoSize = True
        Me.BlankEverynWords.Location = New System.Drawing.Point(12, 14)
        Me.BlankEverynWords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BlankEverynWords.Name = "BlankEverynWords"
        Me.BlankEverynWords.Size = New System.Drawing.Size(103, 21)
        Me.BlankEverynWords.TabIndex = 6
        Me.BlankEverynWords.Text = "Blank every"
        Me.BlankEverynWords.UseVisualStyleBackColor = True
        '
        'ManualBlanking
        '
        Me.ManualBlanking.AutoSize = True
        Me.ManualBlanking.Location = New System.Drawing.Point(12, 39)
        Me.ManualBlanking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ManualBlanking.Name = "ManualBlanking"
        Me.ManualBlanking.Size = New System.Drawing.Size(133, 21)
        Me.ManualBlanking.TabIndex = 7
        Me.ManualBlanking.Text = "Manual Blanking"
        Me.ManualBlanking.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ManualBlanking)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BlankEverynWords)
        Me.GroupBox1.Controls.Add(Me.GetN)
        Me.GroupBox1.Location = New System.Drawing.Point(535, 151)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(219, 68)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'ConfirmBlanks
        '
        Me.ConfirmBlanks.Location = New System.Drawing.Point(595, 223)
        Me.ConfirmBlanks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConfirmBlanks.Name = "ConfirmBlanks"
        Me.ConfirmBlanks.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmBlanks.TabIndex = 9
        Me.ConfirmBlanks.Text = "Confirm"
        Me.ConfirmBlanks.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text file|*.txt"
        Me.SaveFileDialog1.Title = "Save text file"
        '
        'GetOriginalText
        '
        Me.GetOriginalText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetOriginalText.Location = New System.Drawing.Point(36, 112)
        Me.GetOriginalText.Margin = New System.Windows.Forms.Padding(4)
        Me.GetOriginalText.Multiline = True
        Me.GetOriginalText.Name = "GetOriginalText"
        Me.GetOriginalText.ReadOnly = True
        Me.GetOriginalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GetOriginalText.Size = New System.Drawing.Size(431, 523)
        Me.GetOriginalText.TabIndex = 13
        '
        'GetWordBank
        '
        Me.GetWordBank.FormattingEnabled = True
        Me.GetWordBank.ItemHeight = 16
        Me.GetWordBank.Location = New System.Drawing.Point(547, 297)
        Me.GetWordBank.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GetWordBank.Name = "GetWordBank"
        Me.GetWordBank.ScrollAlwaysVisible = True
        Me.GetWordBank.Size = New System.Drawing.Size(185, 324)
        Me.GetWordBank.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 38)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Original Passage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(901, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 38)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "New Passage"
        '
        'BlankNewPassage
        '
        Me.BlankNewPassage.CausesValidation = False
        Me.BlankNewPassage.Location = New System.Drawing.Point(909, 83)
        Me.BlankNewPassage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BlankNewPassage.Name = "BlankNewPassage"
        Me.BlankNewPassage.Size = New System.Drawing.Size(75, 23)
        Me.BlankNewPassage.TabIndex = 19
        Me.BlankNewPassage.Text = "Blank"
        Me.BlankNewPassage.UseVisualStyleBackColor = True
        '
        'ResetNewPassage
        '
        Me.ResetNewPassage.Location = New System.Drawing.Point(1041, 83)
        Me.ResetNewPassage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResetNewPassage.Name = "ResetNewPassage"
        Me.ResetNewPassage.Size = New System.Drawing.Size(75, 23)
        Me.ResetNewPassage.TabIndex = 20
        Me.ResetNewPassage.Text = "Reset"
        Me.ResetNewPassage.UseVisualStyleBackColor = True
        '
        'GetBlankText
        '
        Me.GetBlankText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetBlankText.Location = New System.Drawing.Point(806, 112)
        Me.GetBlankText.Name = "GetBlankText"
        Me.GetBlankText.ReadOnly = True
        Me.GetBlankText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.GetBlankText.Size = New System.Drawing.Size(416, 523)
        Me.GetBlankText.TabIndex = 21
        Me.GetBlankText.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(592, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Word Bank"
        '
        'GetTestFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 673)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GetBlankText)
        Me.Controls.Add(Me.ResetNewPassage)
        Me.Controls.Add(Me.BlankNewPassage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GetWordBank)
        Me.Controls.Add(Me.GetOriginalText)
        Me.Controls.Add(Me.ConfirmBlanks)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GetTestFile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GetN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BlankEverynWords As RadioButton
    Friend WithEvents ManualBlanking As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ConfirmBlanks As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GetOriginalText As TextBox
    Friend WithEvents GetWordBank As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BlankNewPassage As Button
    Friend WithEvents ResetNewPassage As Button
    Friend WithEvents GetBlankText As RichTextBox
    Friend WithEvents Label4 As Label
End Class
