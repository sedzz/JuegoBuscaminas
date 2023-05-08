Imports System.IO
Public Class Usuarios
    Private Const rutaFicheroUsuarios As String = "./Recursos/Ficheros/usuarios.txt"
    Public Property UsuariosTotales As String()
    Public Property Usuarios As New List(Of Usuario)

    Sub New()
        Me.UsuariosTotales = File.ReadAllLines(rutaFicheroUsuarios)
        TiposUsuarios()
    End Sub

    Public Function AñadirUsuario(nombre As String, contraseña As String) As Boolean
        Dim nuevoUsu As New Usuario(nombre, contraseña, 0)
        For Each linea In Usuarios
            If Usuarios.Contains(nuevoUsu) Then
                Return False
            End If
        Next
        If nombre.Contains("-") OrElse contraseña.Contains("-") Then
            Return False
        End If
        Array.Resize(UsuariosTotales, UsuariosTotales.Length + 1)
        UsuariosTotales(UsuariosTotales.Length - 1) = $"{nombre}-{contraseña}-0"
        File.WriteAllLines(rutaFicheroUsuarios, UsuariosTotales)
        Usuarios.Add(New Usuario(nombre, contraseña, 0))
        Return True
    End Function

    Public Sub TiposUsuarios()
        For Each linea In UsuariosTotales
            Dim arrayLinea() As String = linea.Split("-")
            Usuarios.Add(New Usuario(arrayLinea(0), arrayLinea(1), Double.Parse(arrayLinea(2))))
        Next
    End Sub
    Public Function ConectarUsuario(nombre As String, contraseña As String) As Boolean

        For Each linea In Usuarios
            If Usuarios.Contains(linea) Then
                If linea.Contraseña = contraseña Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Public Function CalcularPuntuacion(usuario As Usuario, puntuacion As Double, cantBombas As Integer) As String
        Dim usuarioActual As Usuario
        Dim indice As Integer
        For i = 0 To Usuarios.Count - 1
            If Usuarios.Contains(usuario) Then
                indice = Usuarios.IndexOf(usuario)
                usuarioActual = Usuarios(indice)
                If cantBombas = 10 Then
                    usuarioActual.Puntuacion = puntuacion * 1.5
                ElseIf cantBombas = 40 Then
                    usuarioActual.Puntuacion = puntuacion * 3
                Else
                    usuarioActual.Puntuacion = puntuacion * 10
                End If
                UsuariosTotales(i) = $"{usuarioActual.Nombre}-{usuarioActual.Contraseña}-{usuarioActual.Puntuacion}"
                Return usuarioActual.Puntuacion
            End If

        Next

    End Function

End Class
