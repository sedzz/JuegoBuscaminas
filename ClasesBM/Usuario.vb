Public Class Usuario
    Implements IEquatable(Of Usuario)

    Public Property Nombre As String
    Public Property Contraseña As String
    Public Property Puntuacion As Integer

    Sub New(nombre As String, contraseña As String)
        Me.Nombre = nombre
        Me.Contraseña = contraseña
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Usuario))
    End Function

    Public Overloads Function Equals(other As Usuario) As Boolean Implements IEquatable(Of Usuario).Equals
        Return other IsNot Nothing AndAlso
               Nombre.ToLower = other.Nombre.ToLower
    End Function

    Public Shared Operator =(left As Usuario, right As Usuario) As Boolean
        Return EqualityComparer(Of Usuario).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As Usuario, right As Usuario) As Boolean
        Return Not left = right
    End Operator
End Class
