Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports ClasesBM

Public Class FrmLoginRegistro
    Dim lineas() As String = File.ReadAllLines("./Recursos/Ficheros/usuarios.txt")
    Dim imagenRuta As String = ""
    Dim usuarios As New Usuarios
    Dim ojoAbierto As Boolean = False
    Private Sub FrmLoginRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imagenRuta = "./Recursos/Imagenes/ojoCerrado.png"
        Dim Image As Image = Image.FromFile(imagenRuta)
        btnVerContraseña.Image = Image
    End Sub
    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        If usuarios.AñadirUsuario(txtUsuario.Text, txtContraseña.Text) Then
            MessageBox.Show("Usuario creado correctamente")
            FrmEleccionDificultad.Show()
        Else
            MessageBox.Show("Usuario ya existente")
        End If

    End Sub

    Private Sub btnConectarse_Click(sender As Object, e As EventArgs) Handles btnConectarse.Click
        If usuarios.ConectarUsuario(txtUsuario.Text, txtContraseña.Text) Then
            MessageBox.Show($"Bienvenido {txtUsuario.Text}")
            FrmEleccionDificultad.Show()
        Else
            MessageBox.Show($"Usuario o contraseña invalidos")
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.Click, txtContraseña.Click
        Dim evento As TextBox = sender
        evento.SelectAll()
        txtContraseña.UseSystemPasswordChar = True
    End Sub

    Private Sub btnVerContraseña_Click(sender As Object, e As EventArgs) Handles btnVerContraseña.Click
        If ojoAbierto = True Then
            imagenRuta = "./Recursos/Imagenes/ojoCerrado.png"
            ojoAbierto = False
            txtContraseña.UseSystemPasswordChar = True
        Else
            imagenRuta = "./Recursos/Imagenes/ojoAbierto.png"
            ojoAbierto = True
            txtContraseña.UseSystemPasswordChar = False
        End If

        Dim Image As Image = Image.FromFile(imagenRuta)
        btnVerContraseña.Image = Image

    End Sub
End Class