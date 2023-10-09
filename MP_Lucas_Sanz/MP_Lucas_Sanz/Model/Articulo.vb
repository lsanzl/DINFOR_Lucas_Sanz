Public Class Articulo
    Private codigoArticulo As String
    Private nombreArticulo As String
    Private descripcionArticulo As String
    Private pvpInicialArticulo As Double
    Private pvpCompraArticulo As Double
    Private porcBeneficioArticulo As Integer
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
    Public Property PVPInicialDeArticulo() As Double
        Get
            Return pvpInicialArticulo
        End Get
        Set(value As Double)
            pvpInicialArticulo = value
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
    Public Property PorcentajeDeBeneficio() As Integer
        Get
            Return porcBeneficioArticulo
        End Get
        Set(value As Integer)
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
                   pvpInicialPasado As Double, pvpCompraPasado As Double, porcBeneficioPasado As Integer,
                   tipoArticuloPasado As String, familiaPasada As String)
        MyBase.New()

    End Sub
End Class