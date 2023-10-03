Public Class Empresa
    Private nombreEmp As String
    Private codigoEmp As String
    Public nombreAntiguo As String

    Public managerEmpresa As ManagerEmpresas = New ManagerEmpresas()

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
        nombreEmp = ""
        codigoEmp = ""
    End Sub

    Public Function getEmpresas() As List(Of Empresa)
        Return managerEmpresa.getEmpresas()
    End Function
    Public Sub addEmpresa(nombreEmp As String)
        managerEmpresa.addEmpresa(nombreEmp)
    End Sub
    Public Sub modifyEmpresa()
        managerEmpresa.modificarEmpresa(NombreEmpresa, nombreAntiguo)
    End Sub
    Public Sub deleteEmpresa()
        managerEmpresa.deleteEmpresa(Me.NombreEmpresa)
    End Sub
End Class