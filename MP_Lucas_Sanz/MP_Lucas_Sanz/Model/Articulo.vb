Public Class Articulo
    Private codigoArticulo As String
    Private nombreArticulo As String
    Private descripcionArticulo As String
    Private pvpCompraArticulo As Double
    Private porcBeneficioArticulo As Double
    Private pvpVentaArticulo As Double
    Private tipoUnidadArticulo As String
    Private familiaArticulo As String

    Public Property CodigoDeArticulo() As String
        Get
            Return codigoArticulo
        End Get
        Set(value As String)
            codigoArticulo = value
        End Set
    End Property
    Public Property NombreDeArticulo() As String
        Get
            Return nombreArticulo
        End Get
        Set(value As String)
            nombreArticulo = value
        End Set
    End Property
    Public Property DescripcionDeArticulo() As String
        Get
            Return descripcionArticulo
        End Get
        Set(value As String)
            descripcionArticulo = value
        End Set
    End Property
    Public Property PVPCompraDeArticulo() As Double
        Get
            Return pvpCompraArticulo
        End Get
        Set(value As Double)
            pvpCompraArticulo = value
        End Set
    End Property
    Public Property PorcentajeDeBeneficio() As Double
        Get
            Return porcBeneficioArticulo
        End Get
        Set(value As Double)
            porcBeneficioArticulo = value
        End Set
    End Property
    Public Property PVPVentaDeArticulo() As Double
        Get
            Return pvpVentaArticulo
        End Get
        Set(value As Double)
            pvpVentaArticulo = value
        End Set
    End Property
    Public Property TipoDeUnidadArticulo() As String
        Get
            Return tipoUnidadArticulo
        End Get
        Set(value As String)
            tipoUnidadArticulo = value
        End Set
    End Property
    Public Property FamiliaDeArticulo() As String
        Get
            Return familiaArticulo
        End Get
        Set(value As String)
            familiaArticulo = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(codigoPasado As String, nombrePasado As String, descripcionPasada As String,
                   pvpCompraPasado As Double, porcBeneficioPasado As Double,
                   tipoArticuloPasado As String, familiaPasada As String)
        MyBase.New()
        CodigoDeArticulo = codigoPasado
        NombreDeArticulo = nombrePasado
        DescripcionDeArticulo = descripcionPasada
        PVPCompraDeArticulo = pvpCompraPasado
        PorcentajeDeBeneficio = porcBeneficioPasado
        TipoDeUnidadArticulo = tipoArticuloPasado
        FamiliaDeArticulo = familiaPasada

        PVPVentaDeArticulo = PVPCompraDeArticulo * (1 + PorcentajeDeBeneficio / 100)
    End Sub

    Public Sub setNuevoPrecioVenta(porcBenNuevo As Double)
        PVPVentaDeArticulo = PVPCompraDeArticulo * (1 + porcBenNuevo / 100)
    End Sub

    Public Function getArticulos() As List(Of Articulo)
        Return managerArticuloAux.getArticulos()
    End Function
    Public Sub addArticulo()
        managerArticuloAux.addArticulo(Me)
    End Sub
    Public Sub modifyArticulo()
        managerArticuloAux.modifyArticulo(Me)
    End Sub
    Public Sub deleteArticulo()
        managerArticuloAux.deleteArticulo(Me)
    End Sub
    Public Function checkNombre(nombrePasado As String)
        If nombrePasado.Length > 6 Then
            MessageBox.Show("Código demasiado largo (máx 6)")
            Return False
        End If
        Return True
    End Function
End Class