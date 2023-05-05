Imports System.IO

Public Class Usuarios
    Dim ruta As String = "./Recursos/Ficheros/usuarios.txt"
    Public Property UsuariosTotales As String()

    Sub New()
        Me.UsuariosTotales = File.ReadAllLines(ruta)
    End Sub

    Public Function AñadirUsuario(nombre As String, contraseña As String) As Boolean
        For Each linea In UsuariosTotales
            If linea.StartsWith(nombre) Then
                Return False
            End If
        Next
        If nombre.Contains("-") OrElse contraseña.Contains("-") Then
            Return False
        End If
        Array.Resize(UsuariosTotales, UsuariosTotales.Length + 1)
        UsuariosTotales(UsuariosTotales.Length - 1) = $"{nombre}-{contraseña}"
        File.WriteAllLines(ruta, UsuariosTotales)
        Return True
    End Function

    Public Function ConectarUsuario(nombre As String, contraseña As String) As Boolean

        For Each linea In UsuariosTotales
            If linea.StartsWith(nombre) Then
                Dim arrayLinea() As String = linea.Split("-")
                If arrayLinea(1) = contraseña Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function
End Class
