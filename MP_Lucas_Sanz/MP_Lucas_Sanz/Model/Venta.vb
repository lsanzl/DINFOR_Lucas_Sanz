Public Class Venta
    Private codigoVenta As Integer
    Private clienteVenta As Integer
    Private articuloVenta As String
    Private formaPagoVenta As Integer
    Private precioArticuloVenta As Double
    Private cantidadVenta As Integer
    Private precioTotalVenta As Double
    Private fechaVenta As Date

    Public Property CodigoDeVenta() As Integer
        Get
            Return codigoVenta
        End Get
        Set(value As Integer)
            codigoVenta = value
        End Set
    End Property
    Public Property ClienteDeVenta() As Integer
        Get
            Return clienteVenta
        End Get
        Set(value As Integer)
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
    Public Property FormaDePagoVenta() As Integer
        Get
            Return formaPagoVenta
        End Get
        Set(value As Integer)
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
    Public Property FechaDeVenta() As Date
        Get
            Return fechaVenta
        End Get
        Set(value As Date)
            fechaVenta = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(clienteP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer, fechaP As Date)
        MyBase.New()
        ClienteDeVenta = clienteP
        ArticuloDeVenta = articuloP
        FormaDePagoVenta = formaP
        PrecioDeArticuloVenta = precioP
        CantidadDeVenta = cantidadP
        FechaDeVenta = fechaP
        PrecioTotalDeVenta = PrecioDeArticuloVenta * CantidadDeVenta
    End Sub
    Public Sub New(codigoVentaP As Integer, clienteP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer, fechaP As Date)
        MyBase.New()
        CodigoDeVenta = codigoVentaP
        ClienteDeVenta = clienteP
        ArticuloDeVenta = articuloP
        FormaDePagoVenta = formaP
        PrecioDeArticuloVenta = precioP
        CantidadDeVenta = cantidadP
        FechaDeVenta = fechaP
        PrecioTotalDeVenta = PrecioDeArticuloVenta * CantidadDeVenta
    End Sub
    Public Function getVentas() As List(Of Venta)
        Return managerVentaAux.getVentas()
    End Function
    Public Sub addVenta()
        managerVentaAux.addVenta(Me)
    End Sub
End Class