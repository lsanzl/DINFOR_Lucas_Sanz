Public Class Inventario
    Private nombreArticulo As String
    Private unidades As Integer

    Public Property NombreDeArticulo() As String
        Get
            Return nombreArticulo
        End Get
        Set(value As String)
            nombreArticulo = value
        End Set
    End Property
    Public Property UnidadesDisponibles() As Integer
        Get
            Return unidades
        End Get
        Set(value As Integer)
            unidades = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(nombreArticuloPasado As String, unidadesPasadas As Integer)
        MyBase.New()
        nombreArticulo = nombreArticuloPasado
        unidades = unidadesPasadas
    End Sub

    Public Function getInventario() As List(Of Inventario)
        Return managerInventarioAux.getInventario()
    End Function

    Public Sub addUnidades(cantidadSumar As Integer)
        managerInventarioAux.addUnidades(cantidadSumar, Me)
    End Sub
    Public Sub deleteUnidades(cantidadRestar As Integer)
        managerInventarioAux.deleteUnidades(cantidadRestar, Me)
    End Sub

    Public Sub addInventario()
        If Not checkInventario() Then
            managerInventarioAux.addInventario(Me)
        Else
            MessageBox.Show("Artículo ya presente, se añaden uds nuevas")

            managerInventarioAux.addUnidades(Me.UnidadesDisponibles, Me)
        End If
    End Sub
    Public Sub deleteInventario()
        managerInventarioAux.deleteInventario(Me)
    End Sub
    Public Function checkInventario() As Boolean
        Return managerInventarioAux.checkInventario(Me.NombreDeArticulo)
    End Function
End Class