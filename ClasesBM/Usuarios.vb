﻿Imports System.IO
Public Class Usuarios
    Public Property rutaFicheroUsuarios As String = "./Recursos/Ficheros/usuarios.txt"
    Public Property UsuariosTotales As String()
    Public Property Usuarios As New List(Of Usuario)


    Sub New()
        Me.UsuariosTotales = File.ReadAllLines(rutaFicheroUsuarios)
        TiposUsuarios()
    End Sub

    Public Function AñadirUsuario(nombre As String, contraseña As String) As Boolean
        Dim nuevoUsu As New Usuario(nombre, contraseña, 0)
        If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(contraseña) Then
            Return False
        End If
        If Usuarios.Contains(nuevoUsu) Then
            Return False
        End If
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
        Dim usuarioAuxiliar As New Usuario(nombre, contraseña)
        Dim posicion As Integer = Usuarios.IndexOf(usuarioAuxiliar)
        If posicion = -1 Then
            Return False
        End If

        If Not Usuarios(posicion).Contraseña = contraseña Then
            Return False
        End If
        Return True
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
                Array.Resize(UsuariosTotales, UsuariosTotales.Length + 1)
                UsuariosTotales(UsuariosTotales.Length - 1) = $"{usuarioActual.Nombre}-{usuarioActual.Contraseña}-{usuarioActual.Puntuacion}"
                Return usuarioActual.Puntuacion
            End If

        Next
        Return ""
    End Function

    Public Function PuntuacionUsuarios(usuarios As List(Of Usuario)) As List(Of Usuario)
        Dim usuariosOrdenados As List(Of Usuario) = usuarios.OrderByDescending(Function(usuario) usuario.Puntuacion).ToList

        usuariosOrdenados = usuariosOrdenados.Take(10).ToList
        Return usuariosOrdenados
    End Function

End Class
