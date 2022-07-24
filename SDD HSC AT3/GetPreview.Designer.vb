<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetPreview
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
        Me.GetBlankText = New System.Windows.Forms.TextBox()
        Me.GetWordBank = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'GetBlankText
        '
        Me.GetBlankText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetBlankText.Location = New System.Drawing.Point(12, 140)
        Me.GetBlankText.Multiline = True
        Me.GetBlankText.Name = "GetBlankText"
        Me.GetBlankText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GetBlankText.Size = New System.Drawing.Size(314, 298)
        Me.GetBlankText.TabIndex = 15
        '
        'GetWordBank
        '
        Me.GetWordBank.FormattingEnabled = True
        Me.GetWordBank.ItemHeight = 16
        Me.GetWordBank.Location = New System.Drawing.Point(381, 146)
        Me.GetWordBank.Name = "GetWordBank"
        Me.GetWordBank.ScrollAlwaysVisible = True
        Me.GetWordBank.Size = New System.Drawing.Size(120, 292)
        Me.GetWordBank.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Preview of your Cloze Passage"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 43)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'GetPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetBlankText)
        Me.Controls.Add(Me.GetWordBank)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GetPreview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetBlankText As TextBox
    Friend WithEvents GetWordBank As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
