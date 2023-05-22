Imports System.Text
Imports ClasesBM
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class ComprobarCreacionMinas
    ReadOnly difFacil As New Dificultad(8, 20)
    ReadOnly difMedia As New Dificultad(16, 20)
    ReadOnly difDificl As New Dificultad(27, 20)
    <TestMethod()> Public Sub ComprobarCreacionExitosa()
        Assert.AreEqual(10, difFacil.Bombas)
        Assert.AreEqual(40, difMedia.Bombas)
        Assert.AreEqual(99, difDificl.Bombas)
    End Sub

    <TestMethod()> Public Sub ComprobarCreacionFallida()
        Assert.AreEqual(17, difFacil.Bombas, "Se esperaban 10")
        Assert.AreEqual(30, difMedia.Bombas, "Se esperaban 40")
        Assert.AreEqual(300, difDificl.Bombas, "Se esperaban 99")
    End Sub

End Class