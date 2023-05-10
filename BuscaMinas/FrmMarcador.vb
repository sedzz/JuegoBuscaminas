Imports ClasesBM

Public Class FrmMarcador
    Private Sub Marcador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuarios As New Usuarios
        Dim usuariosOrdenados As List(Of Usuario) = usuarios.PuntuacionUsuarios(usuarios.Usuarios)
        Dim contador = 1

        For Each mejoresUsuarios In usuariosOrdenados
            lstMarcador.Items.Add($"{contador}- {mejoresUsuarios.Nombre} -> {mejoresUsuarios.Puntuacion}")
            contador += 1
        Next


        For i = usuarios.Usuarios.Count - 11 To usuarios.Usuarios.Count Step -1

            lstMarcadorUltimos.Items.Add($"{contador}- {usuarios.Usuarios(i).Nombre} -> {usuarios.Usuarios(i).Puntuacion}")
            contador += 1

        Next






    End Sub

End Class