<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GetFilePath = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StartClozeTest = New System.Windows.Forms.Button()
        Me.GetWordBank = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GetBlankNumber = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GetAnswer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GetBlankText = New System.Windows.Forms.TextBox()
        Me.ResetClozeTest = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GetBlankNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GetFilePath
        '
        Me.GetFilePath.Location = New System.Drawing.Point(35, 356)
        Me.GetFilePath.Name = "GetFilePath"
        Me.GetFilePath.Size = New System.Drawing.Size(75, 54)
        Me.GetFilePath.TabIndex = 14
        Me.GetFilePath.Text = "Open File"
        Me.GetFilePath.UseVisualStyleBackColor = True
        '
        'StartClozeTest
        '
        Me.StartClozeTest.Location = New System.Drawing.Point(124, 356)
        Me.StartClozeTest.Name = "StartClozeTest"
        Me.StartClozeTest.Size = New System.Drawing.Size(104, 54)
        Me.StartClozeTest.TabIndex = 17
        Me.StartClozeTest.Text = "Start Cloze test"
        Me.StartClozeTest.UseVisualStyleBackColor = True
        '
        'GetWordBank
        '
        Me.GetWordBank.FormattingEnabled = True
        Me.GetWordBank.ItemHeight = 16
        Me.GetWordBank.Location = New System.Drawing.Point(385, 49)
        Me.GetWordBank.Name = "GetWordBank"
        Me.GetWordBank.ScrollAlwaysVisible = True
        Me.GetWordBank.Size = New System.Drawing.Size(120, 372)
        Me.GetWordBank.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Wordbank"
        '
        'GetBlankNumber
        '
        Me.GetBlankNumber.Location = New System.Drawing.Point(134, 16)
        Me.GetBlankNumber.Name = "GetBlankNumber"
        Me.GetBlankNumber.Size = New System.Drawing.Size(47, 22)
        Me.GetBlankNumber.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GetAnswer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GetBlankNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(524, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'GetAnswer
        '
        Me.GetAnswer.Location = New System.Drawing.Point(53, 44)
        Me.GetAnswer.Name = "GetAnswer"
        Me.GetAnswer.Size = New System.Drawing.Size(75, 50)
        Me.GetAnswer.TabIndex = 8
        Me.GetAnswer.Text = "Choose blank"
        Me.GetAnswer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Blank Number"
        '
        'GetBlankText
        '
        Me.GetBlankText.Location = New System.Drawing.Point(24, 42)
        Me.GetBlankText.Multiline = True
        Me.GetBlankText.Name = "GetBlankText"
        Me.GetBlankText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GetBlankText.Size = New System.Drawing.Size(314, 298)
        Me.GetBlankText.TabIndex = 21
        '
        'ResetClozeTest
        '
        Me.ResetClozeTest.Location = New System.Drawing.Point(245, 356)
        Me.ResetClozeTest.Name = "ResetClozeTest"
        Me.ResetClozeTest.Size = New System.Drawing.Size(75, 54)
        Me.ResetClozeTest.TabIndex = 20
        Me.ResetClozeTest.Text = "Reset"
        Me.ResetClozeTest.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(619, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 453)
        Me.Controls.Add(Me.GetFilePath)
        Me.Controls.Add(Me.StartClozeTest)
        Me.Controls.Add(Me.GetWordBank)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GetBlankText)
        Me.Controls.Add(Me.ResetClozeTest)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GetBlankNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetFilePath As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StartClozeTest As Button
    Friend WithEvents GetWordBank As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GetBlankNumber As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GetAnswer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GetBlankText As TextBox
    Friend WithEvents ResetClozeTest As Button
    Friend WithEvents Label3 As Label
End Class
