Public Class Empresa
    Private nombreEmp As String
    Private codigoEmp As String
    Public nombreAntiguo As String

    Public Property NombreEmpresa() As String
        Get
            Return nombreEmp
        End Get
        Set(value As String)
            nombreEmp = value
        End Set
    End Property
    Public Property CodigoEmpresa() As String
        Get
            Return codigoEmp
        End Get
        Set(value As String)
            codigoEmp = value
        End Set
    End Property

    Public Sub New(ByVal nombreEmpVal As String, ByVal codigoEmpVal As String)
        MyBase.New()
        nombreEmp = nombreEmpVal
        codigoEmp = codigoEmpVal
    End Sub
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getEmpresas() As List(Of Empresa)
        Return managerEmpAux.getEmpresas()
    End Function
    Public Sub addEmpresa(nombreEmp As String)
        managerEmpAux.addEmpresa(nombreEmp)
    End Sub
    Public Sub modifyEmpresa()
        managerEmpAux.modificarEmpresa(NombreEmpresa, nombreAntiguo)
    End Sub
    Public Sub deleteEmpresa()
        managerEmpAux.deleteEmpresa(Me.NombreEmpresa)
    End Sub

    Public Function checkNombre(nombre As String) As Boolean
        If Not nombre.StartsWith("Emp") Then
            Return False
        End If
        Dim codigo As String = Right(nombre, nombre.Length - 3)
        If Not IsNumeric(codigo) Then
            Return False
        End If
        Return True
    End Function

    Public Function checkEmpresaDB(nombreEmpresa As String) As Boolean
        Return managerEmpAux.checkEmpresa(nombreEmpresa)
    End Function
End Class