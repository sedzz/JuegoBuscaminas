Imports System.IO
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class ArchivosLocalizables

    <TestMethod()> Public Sub ComprobacionExistenciaFicheroUsuarios()
        Dim ruta As String = "../../../Buscaminas/Recursos/Ficheros/usuarios.txt"
        Assert.IsTrue(File.Exists(ruta))
    End Sub

    <TestMethod()> Public Sub ComprobacionExistenciaFicheroUsuariosFallida()
        Dim ruta As String = "../../../Buscaminas/Recursos/klk/usuarios.txt"
        Assert.IsTrue(File.Exists(ruta))
    End Sub

    <TestMethod()> Public Sub ComprobacionCargaUsuarios()
        Dim ruta As String = "../../../Buscaminas/Recursos/Ficheros/usuarios.txt"
        Dim configData As String = File.ReadAllText(ruta)
        Assert.IsNotNull(configData, "No se ha podido cargar el archivo de configuración")
    End Sub

    <TestMethod()> Public Sub ComprobacionCargaUsuariosFallido()
        Dim ruta As String = "../../../Buscaminas/Recursos/mj/usuarios.txt"
        Dim configData As String = File.ReadAllText(ruta)
        Assert.IsNotNull(configData, "No se ha podido cargar el archivo de configuración")
    End Sub

End Class