Public Class Familia
    Private codigoFamilia As Integer
    Private nombreFamilia As String

    Public Property CodigoDeFamilia() As String
        Get
            Return codigoFamilia
        End Get
        Set(value As String)
            codigoFamilia = value
        End Set
    End Property
    Public Property NombreDeFamilia() As String
        Get
            Return nombreFamilia
        End Get
        Set(value As String)
            nombreFamilia = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(codigoPasado As Integer, nombrePasado As String)
        MyBase.New()
        CodigoDeFamilia = codigoPasado
        NombreDeFamilia = nombrePasado
    End Sub

    Public Function getFamilias() As List(Of Familia)
        Return managerFamiliaAux.getFamilias()
    End Function
    Public Sub addFamilia()
        managerFamiliaAux.addFamilia(Me)
    End Sub
    Public Sub modifyFamilia()
        managerFamiliaAux.modifyFamilia(Me)
    End Sub
    Public Sub deleteFamilia()
        managerFamiliaAux.deleteFamilia(Me)
    End Sub
End Class