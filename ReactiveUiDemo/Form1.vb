Imports System.ComponentModel
Imports ReactiveUI

Public Class Form1
  Implements IViewFor(Of Data)

  Public Sub New()
    InitializeComponent()
    WhenActivated(
      Sub(d)
        d(WhenAnyValue(Function(o) o.ViewModel.Name) _
          .Subscribe(
            Sub(name)
              LblMyLabel.Text = name
            End Sub))
      End Sub)
  End Sub

  Public Property ViewModelObj As Object Implements IViewFor.ViewModel
    Get
      Return ViewModel
    End Get
    Set
      ViewModel = Value
    End Set
  End Property

  Public Property ViewModel As Data = New Data Implements IViewFor(Of Data).ViewModel
  Private Sub TxtMyTextBox_TextChanged(sender As Object, e As EventArgs) Handles TxtMyTextBox.TextChanged
    ViewModel.Name = sender.Text
  End Sub
End Class
