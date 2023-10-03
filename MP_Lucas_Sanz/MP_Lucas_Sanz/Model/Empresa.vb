Public Class Empresa
    Private nombreEmp As String
    Private codigoEmp As String

    Public Sub New(ByVal nombreEmpVal As String, ByVal codigoEmpVal As String)
        MyBase.New()
        nombreEmp = nombreEmpVal
        codigoEmp = codigoEmpVal
    End Sub

    Public Function getNombreEmp() As String
        Return nombreEmp
    End Function
    Public Function getCodigoEmp() As String
        Return codigoEmp
    End Function

    Public Sub insertarNuevaEmpresa(nombreEmp As String, codigoEmp As String)

    End Sub
    Public Sub consultarEmpresas()

    End Sub
End Class