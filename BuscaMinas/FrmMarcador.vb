Imports ClasesBM

Public Class FrmMarcador
    Private Sub Marcador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmEleccionDificultad.Hide()
        Dim usuarios As New Usuarios
        Dim usuariosOrdenados As List(Of Usuario) = usuarios.PuntuacionUsuarios(usuarios.Usuarios)
        Dim contador = 1

        For Each mejoresUsuarios In usuariosOrdenados
            If mejoresUsuarios.Puntuacion > 0 Then
                lstMarcador.Items.Add($"{contador}- {mejoresUsuarios.Nombre} -> {mejoresUsuarios.Puntuacion}")
                contador += 1
            End If
        Next

        contador = 0
        For Each usuario In usuarios.Usuarios

            If usuario IsNot Nothing And usuario.Puntuacion > 0 And Not contador = 5 Then
                lstMarcadorUltimos.Items.Add($"{contador + 1}- {usuario.Nombre} -> {usuario.Puntuacion}")
                contador += 1
            End If

        Next
    End Sub
    Private Sub Marcador_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        FrmEleccionDificultad.Show()
    End Sub

    Private Sub btnParaAtras_Click(sender As Object, e As EventArgs) Handles btnParaAtras.Click
        Close()
    End Sub
End Class