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
    Me.LblMyLabel = New System.Windows.Forms.Label()
    Me.TxtMyTextBox = New System.Windows.Forms.TextBox()
    Me.BtnOk = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'LblMyLabel
    '
    Me.LblMyLabel.AutoSize = true
    Me.LblMyLabel.Location = New System.Drawing.Point(170, 116)
    Me.LblMyLabel.Name = "LblMyLabel"
    Me.LblMyLabel.Size = New System.Drawing.Size(46, 13)
    Me.LblMyLabel.TabIndex = 0
    Me.LblMyLabel.Text = "myLabel"
    '
    'TxtMyTextBox
    '
    Me.TxtMyTextBox.Location = New System.Drawing.Point(85, 229)
    Me.TxtMyTextBox.Name = "TxtMyTextBox"
    Me.TxtMyTextBox.Size = New System.Drawing.Size(211, 20)
    Me.TxtMyTextBox.TabIndex = 1
    '
    'BtnOk
    '
    Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.BtnOk.Location = New System.Drawing.Point(434, 355)
    Me.BtnOk.Name = "BtnOk"
    Me.BtnOk.Size = New System.Drawing.Size(74, 22)
    Me.BtnOk.TabIndex = 2
    Me.BtnOk.Text = "Ok"
    Me.BtnOk.UseVisualStyleBackColor = true
    '
    'Form1
    '
    Me.AcceptButton = Me.BtnOk
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(513, 382)
    Me.Controls.Add(Me.BtnOk)
    Me.Controls.Add(Me.TxtMyTextBox)
    Me.Controls.Add(Me.LblMyLabel)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Private WithEvents LblMyLabel As Label
  Private WithEvents TxtMyTextBox As TextBox
  Private WithEvents BtnOk As Button
End Class
