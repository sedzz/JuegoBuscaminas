Imports ClasesBM

Public Class FrmEleccionDificultad
    Private Sub boton_click(sender As Object, e As EventArgs) Handles btnFacil.Click, btnMedio.Click, btnDificil.Click
        Dim boton As Button = TryCast(sender, Button)
        dificultad = New Dificultad
        Select Case boton.Name
            Case "btnFacil"
                dificultad.PosX = 8
                dificultad.PosY = 8
            Case "btnMedio"
                dificultad.PosX = 16
                dificultad.PosY = 16
            Case "btnDificil"
                dificultad.PosX = 30
                dificultad.PosY = 16
        End Select
        FrmTablero.Activate()
        FrmTablero.Show()
        Me.Hide()
    End Sub

End Class