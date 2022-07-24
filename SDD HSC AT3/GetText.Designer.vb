<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetText
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
        Me.NextStep = New System.Windows.Forms.Button()
        Me.TypeText = New System.Windows.Forms.TextBox()
        Me.GetFilePath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NextStep
        '
        Me.NextStep.Location = New System.Drawing.Point(391, 195)
        Me.NextStep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextStep.Name = "NextStep"
        Me.NextStep.Size = New System.Drawing.Size(136, 48)
        Me.NextStep.TabIndex = 21
        Me.NextStep.Text = "Next →"
        Me.NextStep.UseVisualStyleBackColor = True
        '
        'TypeText
        '
        Me.TypeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeText.Location = New System.Drawing.Point(37, 126)
        Me.TypeText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TypeText.Multiline = True
        Me.TypeText.Name = "TypeText"
        Me.TypeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TypeText.Size = New System.Drawing.Size(323, 247)
        Me.TypeText.TabIndex = 20
        '
        'GetFilePath
        '
        Me.GetFilePath.Location = New System.Drawing.Point(141, 22)
        Me.GetFilePath.Name = "GetFilePath"
        Me.GetFilePath.Size = New System.Drawing.Size(111, 47)
        Me.GetFilePath.TabIndex = 22
        Me.GetFilePath.Text = "Open File"
        Me.GetFilePath.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 28)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "or type here"
        '
        'GetText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 395)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetFilePath)
        Me.Controls.Add(Me.NextStep)
        Me.Controls.Add(Me.TypeText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GetText"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NextStep As Button
    Friend WithEvents TypeText As TextBox
    Friend WithEvents GetFilePath As Button
    Friend WithEvents Label1 As Label
End Class
