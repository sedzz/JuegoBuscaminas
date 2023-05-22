Imports System.IO
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class ComprobacionContenidoFicheros

    <TestMethod()> Public Sub PruebaExitosa()
        Dim contenido As New List(Of String)(File.ReadAllLines("../../../Buscaminas/Recursos/Ficheros/usuarios.txt"))
        Dim lineaArray() As String
        Dim esNumero As String
        For Each linea In contenido
            lineaArray = linea.Split("-"c)
            esNumero = lineaArray(2).ToString
            Assert.IsTrue(Double.TryParse(esNumero, lineaArray(2)))
            Assert.AreEqual(3, lineaArray.Length)
        Next
    End Sub

    <TestMethod()> Public Sub PruebaNOExitosa()
        Dim contenido As New List(Of String)(File.ReadAllLines("../../../Buscaminas/Recursos/Ficheros/usuarios.txt"))
        Dim lineaArray() As String
        Dim esNumero As String
        For Each linea In contenido
            lineaArray = linea.Split("."c) ' Da error por que no se separa con puntos
            esNumero = lineaArray(2).ToString
            Assert.IsTrue(Double.TryParse(esNumero, lineaArray(2)), "La puntuacion no puede tener ese valor")
            Assert.AreEqual(3, lineaArray.Length, "Los datos no tiene un valor correcto")
        Next
    End Sub

End Class