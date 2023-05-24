Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ClasesBM

<TestClass()> Public Class ComprobacionUsuarios

    <TestMethod()> Public Sub RegistroExistoso()
        Dim usuarios As New Usuarios
        Dim usuario As String = "kolokentoki" 'vamos a probar a crear un usuario
        Dim contraseña As String = "klk"
        Assert.IsTrue(usuarios.AñadirUsuario(usuario, contraseña))
    End Sub
    <TestMethod()> Public Sub RegistroFallido() 'Ya existe este ususario
        Dim usuarios As New Usuarios

        Dim usuario As String = "sebas"
        Dim contraseña As String = "a"
        Assert.IsTrue(usuarios.AñadirUsuario(usuario, contraseña))
    End Sub
    <TestMethod()> Public Sub AccesoExistoso()
        Dim usuarios As New Usuarios

        Dim usuario As String = "sebas"
        Dim contraseña As String = "1"
        Assert.IsTrue(usuarios.ConectarUsuario(usuario, contraseña))
    End Sub
    <TestMethod()> Public Sub AccesoFallido()
        Dim usuarios As New Usuarios

        Dim usuario As String = "sebas"
        Dim contraseña As String = "a"
        Assert.IsTrue(usuarios.ConectarUsuario(usuario, contraseña))
    End Sub



End Class