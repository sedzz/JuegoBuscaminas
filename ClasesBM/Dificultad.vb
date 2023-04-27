Public Class Dificultad
    Public Property PosX As Integer
    Public Property PosY As Integer
    Public ReadOnly Property Bombas As Integer
        Get
            If PosX = 8 Then
                Return 10
            End If

            If PosX = 16 Then
                Return 40
            End If

            Return 99

        End Get
    End Property

    Sub New(x As Integer, y As Integer)
        Me.PosX = x
        Me.PosY = y
    End Sub
    Sub New()
    End Sub
End Class
