Public Class Banco
    Private nombreBanco As String
    Private codigoBanco As Integer

    Public Property NombreDeBanco() As String
        Get
            Return nombreBanco
        End Get
        Set(value As String)
            nombreBanco = value
        End Set
    End Property
    Public Property CodigoDeBanco() As Integer
        Get
            Return codigoBanco
        End Get
        Set(value As Integer)
            codigoBanco = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(nombreBancoPasado As String, codigoBancoPasado As Integer)
        MyBase.New()
        nombreBanco = nombreBancoPasado
        codigoBanco = codigoBancoPasado
    End Sub

    Public Function getBancos() As List(Of Banco)
        Return managerBancoAux.getBancos()
    End Function

    Public Sub addBanco()
        managerBancoAux.addBanco(Me)
    End Sub

    Public Sub modifyBanco()
        managerBancoAux.modifyBanco(Me)
    End Sub

    Public Sub deleteBanco()
        managerBancoAux.deleteBanco(Me)
    End Sub

    Public Function checkBancoDB(nombreBanco As String) As Boolean
        Return managerBancoAux.checkBanco(nombreBanco)
    End Function
End Class