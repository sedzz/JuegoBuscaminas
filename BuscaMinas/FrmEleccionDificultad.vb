Imports ClasesBM
Imports System.IO

Public Class FrmEleccionDificultad
    Dim ruta As New StreamWriter("..\..\usuarios.txt")
    Private Sub boton_click(sender As Object, e As EventArgs) Handles btnFacil.Click, btnMedio.Click, btnDificil.Click
        Dim boton As Button = TryCast(sender, Button)
        dificultad = New Dificultad
        Select Case boton.Name
            Case "btnFacil"
                dificultad.AnchoX = 8
                dificultad.LargoY = 8
            Case "btnMedio"
                dificultad.AnchoX = 16
                dificultad.LargoY = 16
            Case "btnDificil"
                dificultad.AnchoX = 30
                dificultad.LargoY = 16
        End Select
        FrmTablero.Activate()
        FrmTablero.Show()
        Me.Hide()
    End Sub

    Private Sub btnConectarse_Click(sender As Object, e As EventArgs) Handles btnConectarse.Click
        ruta.WriteLine(txtUsuario.Text & "," & txtContraseña.Text)
        ruta.Close()
    End Sub
End Class