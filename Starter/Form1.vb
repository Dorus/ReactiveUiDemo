Public Class Form1
  Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
    Dim d = new ReactiveUiDemo.Form1()
    if d.ShowDialog() = DialogResult.OK
      MsgBox("Ok!")
    End If
  End Sub
End Class
