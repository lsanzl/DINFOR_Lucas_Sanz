Public Class Empresa
    Private nombreEmp As String
    Private codigoEmp As String
    Private nombreAntiguo As String

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

    Public Sub setNombreAntiguo(nombreAntiguoP As String)
        nombreAntiguo = nombreAntiguoP
    End Sub
    Public Function getNombreAntiguo() As String
        Return nombreAntiguo
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(nombreEmpresaP As String)
        MyBase.New()
        nombreEmp = nombreEmpresaP
        codigoEmp = Right(nombreEmpresaP, nombreEmpresaP.Length - 3)
    End Sub


    Public Function getEmpresas() As List(Of Empresa)
        Return managerEmpAux.getEmpresas()
    End Function
    Public Sub addEmpresa()
        managerEmpAux.addEmpresa(Me)
    End Sub
    Public Sub modifyEmpresa()
        managerEmpAux.modificarEmpresa(Me)
    End Sub
    Public Sub deleteEmpresa()
        managerEmpAux.deleteEmpresa(Me)
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