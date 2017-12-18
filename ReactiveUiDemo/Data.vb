Imports ReactiveUI

Public Class Data
  Inherits ReactiveObject

  Private _name As String = ""

  Property Name As String
    Get
      Return _name
    End Get
    Set
      Me.RaiseAndSetIfChanged(_name, value)
    End Set
  End Property
End Class
