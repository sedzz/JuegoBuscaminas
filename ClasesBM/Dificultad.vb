Public Class Dificultad
    Public Property AnchoX As Integer
    Public Property LargoY As Integer
    Public ReadOnly Property Bombas As Integer
        Get
            If AnchoX = 8 Then
                Return 10
            End If

            If AnchoX = 16 Then
                Return 40
            End If

            Return 99

        End Get
    End Property

    Sub New(x As Integer, y As Integer)
        Me.AnchoX = x
        Me.LargoY = y
    End Sub
    Sub New()
    End Sub
End Class
