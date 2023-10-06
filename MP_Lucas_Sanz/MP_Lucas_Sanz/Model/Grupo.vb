Public Class Grupo
    Private codigoGrupo As String
    Private nombreGrupo As String

    Public Property CodigoDeGrupo() As String
        Get
            Return codigoGrupo
        End Get
        Set(value As String)
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
    Public Sub New(codigoPasado As String, nombrePasado As String)
        MyBase.New()
        CodigoDeGrupo = codigoPasado
        NombreDeGrupo = nombrePasado
    End Sub

    Public Function checkNombreGrupo(nombrePasado As String) As Boolean
        If nombrePasado.Length > 5 Then
            MessageBox.Show("Nombre demasiado largo (Máx 5)")
            Return False
        End If
        Return True
    End Function
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