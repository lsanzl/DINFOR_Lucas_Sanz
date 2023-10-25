Public Class Inventario
    Private codigoInventario As Integer
    Private codigoArticulo As Integer
    Private unidades As Integer
    Private articuloInventario As Articulo

    Public Property CodigoDeInventario() As Integer
        Get
            Return codigoInventario
        End Get
        Set(value As Integer)
            codigoInventario = value
        End Set
    End Property
    Public Property CodigoDeArticulo() As Integer
        Get
            Return codigoArticulo
        End Get
        Set(value As Integer)
            codigoArticulo = value
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
    Public Property ArticuloDeInventario() As Articulo
        Get
            Return articuloInventario
        End Get
        Set(value As Articulo)
            articuloInventario = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(codigoArticuloP As String, unidadesPasadas As Integer)
        MyBase.New()
        CodigoDeArticulo = codigoArticuloP
        UnidadesDisponibles = unidadesPasadas
        getArticulo(CodigoDeArticulo)
    End Sub
    Public Sub New(codigoInventarioPasado As Integer, codigoArticuloP As Integer, unidadesPasadas As Integer)
        MyBase.New()
        CodigoDeInventario = codigoInventarioPasado
        CodigoDeArticulo = codigoArticuloP
        UnidadesDisponibles = unidadesPasadas
        getArticulo(CodigoDeArticulo)
    End Sub
    Public Sub getArticulo(codigo As Integer)
        ArticuloDeInventario = managerArticuloAux.getArticuloConcreto(codigo)
    End Sub

    Public Function getInventario() As List(Of Inventario)
        Return managerInventarioAux.getInventario()
    End Function

    Public Sub addUnidades(cantidadSumar As Integer)
        managerInventarioAux.addUnidades(cantidadSumar, Me.ArticuloDeInventario.CodigoDeArticulo)
    End Sub
    Public Sub deleteUnidades(cantidadRestar As Integer)
        managerInventarioAux.deleteUnidades(cantidadRestar, Me.ArticuloDeInventario.CodigoDeArticulo)
    End Sub
    Public Sub addInventario()
        If Not checkInventario() Then
            managerInventarioAux.addInventario(Me)
        Else
            MessageBox.Show("Artículo ya presente, se añaden uds nuevas")
            managerInventarioAux.addUnidades(Me.UnidadesDisponibles, Me.ArticuloDeInventario.CodigoDeArticulo)
        End If
    End Sub
    Public Sub deleteInventario()
        managerInventarioAux.deleteInventario(Me)
    End Sub
    Public Function checkInventario() As Boolean
        Return managerInventarioAux.checkInventario(Me.ArticuloDeInventario)
    End Function
End Class