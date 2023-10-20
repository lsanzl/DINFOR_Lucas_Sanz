Public Class Grupo
    Private codigoGrupo As Integer
    Private nombreGrupo As String

    Public Property CodigoDeGrupo() As Integer
        Get
            Return codigoGrupo
        End Get
        Set(value As Integer)
            codigoGrupo = value
        End Set
    End Property
    Public Property NombreDeGrupo() As String
        Get
            Return nombreGrupo
        End Get
        Set(value As String)
            nombreGrupo = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(codigoPasado As Integer, nombrePasado As String)
        MyBase.New()
        CodigoDeGrupo = codigoPasado
        NombreDeGrupo = nombrePasado
    End Sub
    Public Sub addGrupo()
        managerGrupoAux.addGrupo(Me)
    End Sub
    Public Sub modifyGrupo()
        managerGrupoAux.modifyGrupo(Me)
    End Sub
    Public Sub deleteGrupo()
        managerGrupoAux.deleteGrupo(Me)
    End Sub
    Public Function getGrupos() As List(Of Grupo)
        Return managerGrupoAux.getGrupos()
    End Function
End Class