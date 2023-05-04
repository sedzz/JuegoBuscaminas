﻿Imports ClasesBM
Imports System.IO

Public Class FrmEleccionDificultad

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
        Dim ruta As New StreamWriter("..\..\usuarios.txt")
        ' Dim booleanoRuta As Boolean = False
        ' If booleanoRuta = True Then
        'for
        ruta.WriteLine(ruta.ToString & txtUsuario.Text & "," & txtContraseña.Text)
        ' End If

        ruta.Close()
        ' booleanoRuta = True
    End Sub

    Private Sub FrmEleccionDificultad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagenFondo As Image = Image.FromFile("../../imagenes/fotoFondo.png")
        BackgroundImage = imagenFondo
        Width = 620
        Height = 400
    End Sub
End Class