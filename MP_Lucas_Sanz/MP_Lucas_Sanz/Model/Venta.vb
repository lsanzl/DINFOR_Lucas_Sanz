Public Class Venta
    Private clienteVenta As String
    Private articuloVenta As String
    Private formaPagoVenta As String
    Private precioArticuloVenta As Double
    Private cantidadVenta As Integer
    Private precioTotalVenta As Double

    Public Property ClienteDeVenta() As String
        Get
            Return clienteVenta
        End Get
        Set(value As String)
            clienteVenta = value
        End Set
    End Property
    Public Property ArticuloDeVenta() As String
        Get
            Return articuloVenta
        End Get
        Set(value As String)
            articuloVenta = value
        End Set
    End Property
    Public Property FormaDePagoVenta() As String
        Get
            Return formaPagoVenta
        End Get
        Set(value As String)
            formaPagoVenta = value
        End Set
    End Property
    Public Property PrecioDeArticuloVenta() As Double
        Get
            Return precioArticuloVenta
        End Get
        Set(value As Double)
            precioArticuloVenta = value
        End Set
    End Property
    Public Property CantidadDeVenta() As Integer
        Get
            Return cantidadVenta
        End Get
        Set(value As Integer)
            cantidadVenta = value
        End Set
    End Property
    Public Property PrecioTotalDeVenta() As Double
        Get
            Return precioTotalVenta
        End Get
        Set(value As Double)
            precioTotalVenta = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(clienteP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer)
        MyBase.New()
        ClienteDeVenta = clienteP
        ArticuloDeVenta = articuloP
        FormaDePagoVenta = formaP
        PrecioDeArticuloVenta = precioP
        CantidadDeVenta = cantidadP
        PrecioTotalDeVenta = PrecioDeArticuloVenta * CantidadDeVenta
    End Sub

    Public Function getVentas() As List(Of Venta)
        Return managerVentaAux.getVentas()
    End Function

    Public Sub addVenta()
        managerVentaAux.addVenta(Me)
    End Sub
End Class